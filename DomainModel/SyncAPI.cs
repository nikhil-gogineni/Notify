using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class SyncAPI
    {
        //URL for api calls.
        private string _BaseURL;

        private string _token;

        public SyncAPI(string URL, string token)
        {
            _token = token;
            _BaseURL = URL;
        }

        private HttpClient CreateHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_BaseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", _token);

            return client;
        }

        public async Task<T> Get<T>(string route)
        {
            try
            {
                HttpClient client = CreateHttpClient();

                string callingURL = route;

                using (client)
                {
                    HttpResponseMessage response = await client.GetAsync(callingURL);

                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                    }

                    // Returning error message
                    var message = JsonConvert.DeserializeObject<Dictionary<string, string>>(await response.Content.ReadAsStringAsync());
                    throw new Exception(message["Message"]);
                }
            }
            catch(System.Exception ex)
            {
                throw;
            }
        }

        public async Task<U> Post<T, U>(T data, string route)
        {
            try
            {
                StringContent content = null;

                if (data != null)
                {
                    string jsonData = JsonConvert.SerializeObject(data);
                    content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                }

                HttpClient client = CreateHttpClient();

                // using string builder since _URL is static
                string postingURL = _BaseURL + route;

                using (client)
                {
                    HttpResponseMessage response = await client.PostAsync(postingURL, data != null ? content : null);

                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<U>(await response.Content.ReadAsStringAsync());
                    }

                    // Returning error message
                    var message = JsonConvert.DeserializeObject<Dictionary<string, string>>(await response.Content.ReadAsStringAsync());
                    throw new Exception(message["Message"]);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}