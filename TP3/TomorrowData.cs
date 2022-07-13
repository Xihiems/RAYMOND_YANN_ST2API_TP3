using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class TomorrowData
    {
        public double Temperature { get; set; }
        public int Pressure { get; set; }
        public double Windspeed { get; set; }
        public int Humidity { get; set; }

        public string Icon { get; set; }

        public string Date { get; set; }

        public TomorrowData(double temperature, int pressure,double windspeed, int humidity, string icon,string date) 
        {
            this.Temperature = temperature;
            this.Pressure = pressure;   
            this.Windspeed = windspeed;
            this.Humidity = humidity;   
            this.Icon = icon; 
            this.Date = date;
        }

    }
}
