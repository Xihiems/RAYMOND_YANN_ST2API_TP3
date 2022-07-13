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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                textBox2.Text = "Please select a value not null";
            }
            else
            {
                string city = comboBox1.SelectedItem.ToString();
                Api openweather = new Api();
                if (city == "Berlin") 
                {
                    Berlin berlin = new Berlin();
                    Root datacity = await openweather.GetValuesBySymbol(berlin);
                    WeatherPage weatherpage=new WeatherPage(city,datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Jakarta")
                {
                    Jakarta jakarta = new Jakarta();
                    Root datacity = await openweather.GetValuesBySymbol(jakarta);
                    WeatherPage weatherpage = new WeatherPage(city, datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Kiev")
                {
                    Kiev kiev = new Kiev();
                    Root datacity = await openweather.GetValuesBySymbol(kiev);
                    WeatherPage weatherpage = new WeatherPage(city, datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Morocco")
                {
                    Morocco morocco = new Morocco();
                    Root datacity = await openweather.GetValuesBySymbol(morocco);
                    WeatherPage weatherpage = new WeatherPage(city, datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Moscow")
                {
                    Moscow moscow = new Moscow();
                    Root datacity = await openweather.GetValuesBySymbol(moscow);
                    WeatherPage weatherpage = new WeatherPage(city, datacity);
                    weatherpage.ShowDialog();
                }
                if (city == "New-York") 
                {
                    NewYork newyork = new NewYork();
                    Root datacity = await openweather.GetValuesBySymbol(newyork);
                    WeatherPage weatherpage=new WeatherPage(city,datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Oslo") 
                {
                    Oslo oslo = new Oslo();
                    Root datacity = await openweather.GetValuesBySymbol(oslo);
                    WeatherPage weatherpage=new WeatherPage(city,datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Paris") 
                {
                    Paris paris = new Paris();
                    Root datacity = await openweather.GetValuesBySymbol(paris);
                    WeatherPage weatherpage=new WeatherPage(city,datacity);
                    weatherpage.ShowDialog();

                }
                if (city == "Tokyo")
                {
                    Tokyo tokyo = new Tokyo();
                    Root datacity = await openweather.GetValuesBySymbol(tokyo);
                    WeatherPage weatherpage = new WeatherPage(city, datacity);
                    weatherpage.ShowDialog();

                }
                this.Close();

            }

            
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                textBox2.Text = "Please select a value not null";
            }
            else
            {
                string city = comboBox1.SelectedItem.ToString();
                Api openweather = new Api();
                if (city == "Berlin")
                {
                    Berlin berlin = new Berlin();
                    Root datacity = await openweather.GetValueForecast(berlin);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Jakarta")
                {
                    Jakarta jakarta = new Jakarta();
                    Root datacity = await openweather.GetValueForecast(jakarta);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Kiev")
                {
                    Kiev kiev = new Kiev();
                    Root datacity = await openweather.GetValueForecast(kiev);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Morocco")
                {
                    Morocco morocco = new Morocco();
                    Root datacity = await openweather.GetValueForecast(morocco);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Moscow")
                {
                    Moscow moscow = new Moscow();
                    Root datacity = await openweather.GetValueForecast(moscow);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "New-York")
                {
                    NewYork newYork = new NewYork();
                    Root datacity = await openweather.GetValueForecast(newYork);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Oslo")
                {
                    Oslo oslo = new Oslo();
                    Root datacity = await openweather.GetValueForecast(oslo);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Paris")
                {
                    Paris paris = new Paris();
                    Root datacity = await openweather.GetValueForecast(paris);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
                if (city == "Tokyo")
                {
                    Tokyo tokyo = new Tokyo();
                    Root datacity = await openweather.GetValueForecast(tokyo);
                    ForecastWeather forecastweatherpage = new ForecastWeather(city, datacity);
                    forecastweatherpage.ShowDialog();

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                textBox2.Text = "Please select a value not null";
            }
            else
            {
                string city = comboBox1.SelectedItem.ToString();
                Api openweather = new Api();
                if (city == "Berlin")
                {
                    Berlin berlin = new Berlin();
                    Root datacity = await openweather.GetValueForecast(berlin);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Jakarta")
                {
                    Jakarta jakarta = new Jakarta();
                    Root datacity = await openweather.GetValueForecast(jakarta);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Kiev")
                {
                    Kiev kiev = new Kiev();
                    Root datacity = await openweather.GetValueForecast(kiev);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Morocco")
                {
                    Morocco morocco = new Morocco();
                    Root datacity = await openweather.GetValueForecast(morocco);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Moscow")
                {
                    Moscow moscow = new Moscow();
                    Root datacity = await openweather.GetValueForecast(moscow);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "New-York")
                {
                    NewYork newYork = new NewYork();
                    Root datacity = await openweather.GetValueForecast(newYork);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Oslo")
                {
                    Oslo oslo = new Oslo();
                    Root datacity = await openweather.GetValueForecast(oslo);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Paris")
                {
                    Paris paris = new Paris();
                    Root datacity = await openweather.GetValueForecast(paris);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
                if (city == "Tokyo")
                {
                    Tokyo tokyo = new Tokyo();
                    Root datacity = await openweather.GetValueForecast(tokyo);
                    TomorrowWeather tomorrowweatherpage = new TomorrowWeather(city, datacity);
                    tomorrowweatherpage.ShowDialog();

                }
            }
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteCity writecity = new WriteCity();
            writecity.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteCoordinates writecoordinates = new WriteCoordinates();
            writecoordinates.ShowDialog();
            this.Close();
        }
    }
}
