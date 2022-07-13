using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Api
    {
        private readonly HttpClient _client;
        private static string _url = "https://api.openweathermap.org/data/2.5/";
        private readonly string _key;

        public Api()
        {
            _client = new HttpClient();
            _key = "9a692dcccf4a05a3cae8c9069c1ac13a";
        }

        public async Task<Root> GetValuesBySymbol(Coordinates coordinates)
        {

            string url = $"{_url}onecall?lat={coordinates._latitude}&lon={coordinates._longitude}&units=metric&appid={_key}";

            var json = await GetGlobalDataAsync(url);
            Root data = JsonConvert.DeserializeObject<Root>(json);

            return data;
        }

        public async Task<Root> GetValueForecast(Coordinates coordinates)
        {

            string url = $"{_url}forecast?lat={coordinates._latitude}&lon={coordinates._longitude}&units=metric&appid={_key}";

            var json = await GetGlobalDataAsync(url);
            Root data = JsonConvert.DeserializeObject<Root>(json);

            return data;
        }

        public async Task<Root> GetValuewithcity(string city)
        {

            string url = $"{_url}weather?q={city}&units=metric&appid={_key}";

            var json = await GetGlobalDataAsync(url);
            Root data = JsonConvert.DeserializeObject<Root>(json);

            return data;
        }

        public async Task<string> GetGlobalDataAsync(string url)
        {
            try
            {
                var data = string.Empty;
                using (var response = await _client.GetAsync(url))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        data = await response.Content.ReadAsStringAsync();
                    }
                    return data;
                }

            }
            catch (Exception ex) 
            {
                throw ;
            }
        }
    }
}
