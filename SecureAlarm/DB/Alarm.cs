using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmoSecure.DB
{
    public class Alarm
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public string HourEnabled { get; set; }
        public string HourDisabled { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }
        public int Programer { get; set; }
        public string IP { get; set; }
    }
}
