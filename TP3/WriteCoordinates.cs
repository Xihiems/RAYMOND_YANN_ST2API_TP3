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
    public partial class WriteCoordinates : Form
    {
        public WriteCoordinates()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                textBox3.Text = "Latitude or longitude has a problem";
            }
            else 
            {
                Api openweather = new Api();
                float latitude = float.Parse(textBox1.Text.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                float longitude = float.Parse(textBox2.Text, System.Globalization.CultureInfo.InvariantCulture);
                Coordinates coordinateswrite = new Coordinates(latitude,longitude);
                Root datacity = await openweather.GetValuesBySymbol(coordinateswrite);
                WeatherPage weatherpage = new WeatherPage(coordinateswrite, datacity);
                weatherpage.ShowDialog();
                this.Close();

            }



        }


        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
