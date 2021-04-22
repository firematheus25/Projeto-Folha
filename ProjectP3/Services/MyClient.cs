using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectP3.Services
{
    public class MyClient
    {
        public string BaseAddress { get; set; } = "https://localhost:5001";
        public MyClient()
        {

        }

        public Uri BuilderUri(string Uri)
        {
            return new Uri($"{BaseAddress}/{Uri}");
        }
    }
}
