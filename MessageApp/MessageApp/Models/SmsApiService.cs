using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;


namespace MessageApp.Models
{
    public class SmsApiService
    {

        
        public  string apiSmsGonder(string mesaj, string numaralar)
        {

               
            SmsModel sms = new SmsModel
            {
                api_id = "kendi id'iniz",
                api_key = "kendi key'iniz",
                message = mesaj,
                message_type = "normal",
                sender = " gönderen adınız",
                phones = new string[] { numaralar }
            };
         
           
            var client = new RestSharp.RestClient("https://api.vatansms.net/api/v1/1toN");

           client.Timeout = -1;

            var request = new RestRequest("https://api.vatansms.net/api/v1/1toN", Method.POST);

            request.AddHeader("Content-Type", "application/json");

           

            var body = JsonConvert.SerializeObject(sms);

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
           
            return response.Content.ToString();
           

        }
    }
}
