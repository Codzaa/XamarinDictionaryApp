using DictionaryApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services
{
    public class ApiServices
    {
        private HttpClient client;
        private JsonSerializer _serializer = new JsonSerializer();
        public string app_id = "fc5ef63d";
        public string app_key = "71a6c023af6c57bb8f0ba76e070890c6";
        public string api_Base = "https://od-api.oxforddictionaries.com/api/v2/";

        public static ApiServices _ServiceClientInstance;
        public static ApiServices ServiceClientInstance
        {
            get
            {
                if (_ServiceClientInstance == null)
                    _ServiceClientInstance = new ApiServices();
                return _ServiceClientInstance;
            }
        }

        public ApiServices()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(api_Base);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("app_id",app_id);
            client.DefaultRequestHeaders.Add("app_key",app_key);
            //string authorizationHeaderValue = app_id+app_key;
            //client.DefaultRequestHeaders.Add("Authorization", authorizationHeaderValue);
            //client.DefaultRequestHeaders.Add("app")
        }

        //
        public async Task<Word> testFunction()
        {
            string endpoint = "entries/en-gb/eat";
            var example = new StringContent("example",Encoding.UTF8,"application/json");
            try
            {
                //var response = await client.PostAsync(endpoint,example);
                var response = await client.GetAsync(endpoint);
                //response.EnsureSuccessStatusCode();
                using(var stream = await response.Content.ReadAsStreamAsync())
                using(var reader = new StreamReader(stream))
                using(var json = new JsonTextReader(reader))
                {
                    var jsonContent = _serializer.Deserialize<Word>(json);
                    Console.WriteLine(reader.ReadToEnd());
                    return jsonContent;
                }
            }catch(Exception e)
            {
                //Console.WriteLine(response.StatusCode);
                Console.WriteLine("Noooooooooooo");
                return null;
            }
        }

    }
}
