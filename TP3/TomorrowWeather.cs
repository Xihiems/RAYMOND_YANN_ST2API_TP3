using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class TomorrowWeather : Form
    {
        public TomorrowWeather(string city, Root datacity)
        {
            InitializeComponent();
            textBox1.Text = city;
            List<TomorrowData> listtomorrowdata = new List<TomorrowData>();
            foreach (var i in datacity.list)
            {
                listtomorrowdata.Add(new TomorrowData(i.main.temp, i.main.pressure,i.wind.speed, i.main.humidity,i.weather[0].icon,i.dt_txt.ToString("dd-MM-yyyy")));
            }
            var groupedminmaxdate = listtomorrowdata.GroupBy(u => u.Date).Select(grp => grp.ToList()).ToList();
            List<double> listtemp = new List<double>();
            List<double> listwindspeed = new List<double>();
            List<int> listhumidity = new List<int>();
            List<int> listpressure = new List<int>();
            for (var i = 0; i < groupedminmaxdate[1].Count(); i++) 
            {
                listtemp.Add(groupedminmaxdate[1][i].Temperature);
                listwindspeed.Add(groupedminmaxdate[1][i].Windspeed);
                listhumidity.Add(groupedminmaxdate[1][i].Humidity);
                listpressure.Add(groupedminmaxdate[1][i].Pressure);
            }
            var temp = listtemp.Average();
            var windspeed =(float)Math.Round(listwindspeed.Average(),2);
            var humidity = listhumidity.Average();
            var pressure = listpressure.Average();

            textBox2.Text += " " + temp.ToString() + " C°";
            textBox3.Text += " " + humidity.ToString() + " %";
            textBox4.Text += " " + pressure.ToString() + " hPa";
            textBox5.Text += " " + windspeed.ToString() + " m/s";

            var nbitems = groupedminmaxdate[1].Count();

            pictureBox1.Load("http://openweathermap.org/img/w/" + groupedminmaxdate[1][nbitems / 2].Icon + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
