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
    public partial class WeatherPage : Form
    {
        public WeatherPage(string city,Root datacity)
        {
            InitializeComponent();
            textBox1.Text=city;
            textBox2.Text+= " "+datacity.current.temp.ToString()+" C°";
            textBox3.Text+= " " + datacity.current.humidity + " %";
            textBox4.Text += " " + datacity.current.pressure + " hPa";
            textBox5.Text += " " + datacity.current.wind_speed + " m/s";
            var sunrisedatacity = ConvertFromUnixTimestamp(datacity.current.sunrise);
            textBox7.Text += " " + sunrisedatacity.ToString("T") + " UTC";
            var sunsetdatacity = ConvertFromUnixTimestamp(datacity.current.sunset);
            textBox6.Text += " " + sunsetdatacity.ToString("T")+ " UTC";
            pictureBox1.Load("http://openweathermap.org/img/w/"+datacity.current.weather[0].icon+".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        public WeatherPage(Coordinates coordinates, Root datacity)
        {
            InitializeComponent();
            textBox1.Text = "Weather for lat = "+coordinates._latitude.ToString()+" lon = "+coordinates._longitude.ToString();
            textBox2.Text += " " + datacity.current.temp.ToString() + " C°";
            textBox3.Text += " " + datacity.current.humidity + " %";
            textBox4.Text += " " + datacity.current.pressure + " hPa";
            textBox5.Text += " " + datacity.current.wind_speed + " m/s";
            var sunrisedatacity = ConvertFromUnixTimestamp(datacity.current.sunrise);
            textBox7.Text += " " + sunrisedatacity.ToString("T") + " UTC";
            var sunsetdatacity = ConvertFromUnixTimestamp(datacity.current.sunset);
            textBox6.Text += " " + sunsetdatacity.ToString("T") + " UTC";
            pictureBox1.Load("http://openweathermap.org/img/w/" + datacity.current.weather[0].icon + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeatherPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time");

            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);//on recupere la date zero de référence : le 1/1/1970 00:00:00
            return origin.AddSeconds(timestamp);//on ajoute le timestamp (nombre de secondes depuis la date zero)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
