using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Services.Base
{
    public partial class Client :IClient
    {
        public string BaseAddress { get; set; }

        public HttpClient HttpClient {
            get
            {
                return _httpClient;
            }
        }
    }
}
