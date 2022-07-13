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
    public partial class WriteCity : Form
    {
        public WriteCity()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // normally use regex
            if (textBox1.Text == "")
            {
                textBox3.Text = "your city is null";

            }
            else 
            {
                Api openweather = new Api();
                var city = textBox1.Text.ToString();
                Root datacity = await openweather.GetValuewithcity(city);
                WeatherPage weatherpage = new WeatherPage(city, datacity);
                weatherpage.ShowDialog();
            }
        }
    }
}
