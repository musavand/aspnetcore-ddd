using Contact.Managment.MVC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly ILocalStorageService _localStorage;
        protected IClient _client;
        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

        protected Response<Guid> ConvertApiExecptions<Guid>(ApiException ex)
        {
            if(ex.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "validation error", ValidationErrors = ex.Response , Success=false};
            }
            else if (ex.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "not found", ValidationErrors = ex.Response, Success = false };
            }
            else 
            {
                return new Response<Guid>() { Message = "trye again", ValidationErrors = ex.Response, Success = false };
            }
        }

        protected void AddBearerToken()
        {
            if (_localStorage.Exist("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",_localStorage.GetStorageValue<string>("token"));
            }
        }
    }
}
