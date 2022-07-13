using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class MinMaxDate
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public string Date { get; set; }
        public string Imageid { get; set; }

        public MinMaxDate(double min, double max, string date,string imageid) 
        {
            this.Min = min;
            this.Max = max;
            this.Date = date;
            this.Imageid = imageid;
        }

    }
}
