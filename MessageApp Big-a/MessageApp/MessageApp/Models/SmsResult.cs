using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.Models
{
    public class SmsResult
    {
        public string id { get; set; }
        public string status { get; set; }
        public string quantity { get; set; }
        public string description { get; set; }
        public string numberCount { get; set; }
    }
}
