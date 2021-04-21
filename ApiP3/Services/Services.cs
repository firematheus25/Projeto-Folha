using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiP3.Services
{
    public class Services<T> : MyClient
    {
        public async Task<HttpResponseMessage> Post(string Api, T Objeto)
        {
            using (var client = new HttpClient())
            {
                var Url = new MyClient().BuilderUri(Api);

                var Content = new StringContent(JsonConvert.SerializeObject(Objeto, Formatting.None), Encoding.UTF8, "application/Json");

                return await client.PostAsync(Url, Content);
            }

        }
    }
}
