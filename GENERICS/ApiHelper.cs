using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace pokemones.GENERICS
{
    public class ApiHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<T>GetFromApi<T>(string url)
        {
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode) 
            { 
             string responseBody=await responseMessage.Content.ReadAsStringAsync();
                T data = JsonConvert.DeserializeObject<T>(responseBody);
                return data;

            }
            else
            {
                throw new Exception($"Error al consultar la API: {responseMessage.StatusCode}");
            }
        }
    }
}
