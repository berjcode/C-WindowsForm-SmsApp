using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
                api_id = "ed85cc5098b77d7e9227a367",
                api_key = "6ac37cc8ecad4098957c957c",
                message = mesaj,
                message_type = "normal",
                sender = "CELEBI SPOR",
                phones = new string[] { numaralar }
            };

            var client = new RestSharp.RestClient("https://api.vatansms.net/api/v1/1toN");

           client.Timeout = -1;

            var request = new RestRequest("https://api.vatansms.net/api/v1/1toN", Method.POST);

            request.AddHeader("Content-Type", "application/json");

            //var bo dy = @"{""api_id"": ""7e6a11093050a234eabcbffd"",""api_key"": ""6c8ba38d4b44417db9c33c0d"",""sender"": ""SMS TEST"",""message_type"": ""normal"",""message"":""Bu bir test mesajıdır."",""phones"": [""5365132174""]}";

            var body = JsonConvert.SerializeObject(sms);

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
             //System.Windows.Forms.MessageBox.Show(response.Content);
            return response.Content.ToString();
           

        }
    }
}
