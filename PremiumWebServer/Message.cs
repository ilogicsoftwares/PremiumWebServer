using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumWebServer
{
    class Message
    {
        public string Type { get; set; }
        public string Msg { get; set; }
        public string Table { get; set; }
        public string Camps { get; set; }
        public string Where { get; set; }
        public string Values { get; set; }
        public string From { get; set; }
        public string Function { get; set; }
    }
}
