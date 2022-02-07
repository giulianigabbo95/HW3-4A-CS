using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatistics
{
    public class CovidStat
    {
        public string Direction { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public string Weekday { get; set; }
        public string Country { get; set; }
        public string Commodity { get; set; }
        public string Transport_Mode { get; set; }
        public string Measure { get; set; }
        public double Value { get; set; }
        public double Cumulative { get; set; }
    }
}
