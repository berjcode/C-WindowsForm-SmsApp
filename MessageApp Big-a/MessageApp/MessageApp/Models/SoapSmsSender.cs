using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.Models
{
   public class SoapSmsSender
    {
        public string SmsGonder(
            Sms sms
            )
        {
            //kno.Text= MÜŞTERİ NUMARASI
            //kad.Text= KULLANICI ADI
            //ksifre.Text= ŞİFRE
            //orjinator.Text= ORJİNATÖR (ONAYLI VE TAM DOĞRU OLMALIDIR)

            //xml içerisinde aşağıdaki gibi değerleri gönderebilirsiniz..
            //<zaman>2014-04-17 08:30:00</zaman>//sms gitmeye başlama zamanı
            //<zamanasimi>2014-04-17 10:30:00</zamanasimi>//son gönderim deneme zamanı
            sms.tur = "Normal";//"Turkce"
            string sms1N = "data=<sms><kno>" + sms.kno + "</kno><kulad>" + sms.kad + "</kulad><sifre>" + sms.ksifre + "</sifre>" +
                "<gonderen>" + sms.orjinator + "</gonderen>" +
                "<mesaj>" + sms.mesaj + "</mesaj>" +
                "<numaralar>" + sms.numaralar + "</numaralar>" +
                "<tur>" + sms.tur + "</tur></sms>";
            var sonuc = XmlPost("http://panel.vatansms.com/panel/smsgonder1Npost.php", sms1N);
            return sonuc;
        }

        private string XmlPost(string PostAddress, string xmlData)
        {
            using (WebClient wUpload = new WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }
        }
    }
}
