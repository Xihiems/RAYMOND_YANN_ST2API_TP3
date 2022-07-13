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
    public partial class ForecastWeather : Form
    {
        public ForecastWeather(string city, Root datacity)
        {
            InitializeComponent();
            textBox1.Text = city;
            List<MinMaxDate> listminmaxdate = new List<MinMaxDate>();
            foreach (var i in datacity.list)
            {
                listminmaxdate.Add(new MinMaxDate(i.main.temp_min, i.main.temp_max, i.dt_txt.ToString("dd-MM-yyyy"),i.weather[0].icon));
            }
            var groupedminmaxdate = listminmaxdate.GroupBy(u => u.Date).Select(grp => grp.ToList()).ToList();
            List<double> listmaxfinal = new List<double>();
            List<double> listminfinal = new List<double>();

            for (int i = 1; i < groupedminmaxdate.Count; i++)
            {
                List<double> listmax = new List<double>();
                List<double> listmin = new List<double>();
                for (int j = 0; j < groupedminmaxdate[i].Count; j++)
                {
                    listmax.Add(groupedminmaxdate[i][j].Max);
                    listmin.Add(groupedminmaxdate[i][j].Min);
                }
                listmaxfinal.Add(listmax.Max());
                listminfinal.Add(listmin.Min());
            }
            
            textBox2.Text = groupedminmaxdate[1][0].Date.ToString();
            int indexicon1 = groupedminmaxdate[1].Count();
            pictureBox1.Load("http://openweathermap.org/img/w/" + groupedminmaxdate[1][indexicon1/2].Imageid + ".png");
            textBox3.Text = listminfinal[0].ToString()+" / "+listmaxfinal[0].ToString()+ " C°";
            textBox5.Text = groupedminmaxdate[2][0].Date.ToString();
            int indexicon2 = groupedminmaxdate[2].Count();
            pictureBox2.Load("http://openweathermap.org/img/w/" + groupedminmaxdate[1][indexicon2 / 2].Imageid + ".png");
            textBox4.Text = listminfinal[1].ToString() + " / " + listmaxfinal[1].ToString() + " C°";
            textBox7.Text = groupedminmaxdate[3][0].Date.ToString();
            int indexicon3 = groupedminmaxdate[3].Count();
            pictureBox3.Load("http://openweathermap.org/img/w/" + groupedminmaxdate[1][indexicon3 / 2].Imageid + ".png");
            textBox6.Text = listminfinal[2].ToString() + " / " + listmaxfinal[2].ToString() + " C°";
            textBox9.Text = groupedminmaxdate[4][0].Date.ToString();
            int indexicon4 = groupedminmaxdate[4].Count();
            pictureBox4.Load("http://openweathermap.org/img/w/" + groupedminmaxdate[1][indexicon4 / 2].Imageid + ".png");
            textBox8.Text = listminfinal[3].ToString() + " / " + listmaxfinal[3].ToString() + " C°";
            textBox11.Text = groupedminmaxdate[5][0].Date.ToString();
            int indexicon5 = groupedminmaxdate[5].Count();
            pictureBox5.Load("http://openweathermap.org/img/w/" + groupedminmaxdate[1][indexicon5 / 2].Imageid + ".png");
            textBox10.Text = listminfinal[4].ToString() + " / " + listmaxfinal[4].ToString() + " C°";

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForecastWeather_Load(object sender, EventArgs e)
        {

        }
    }
}
