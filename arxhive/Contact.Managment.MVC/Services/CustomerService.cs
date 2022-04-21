using Contact.Managment.MVC.Contracts;
using Contact.Managment.MVC.Models;
using Contact.Managment.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Management.Appliaction.DTOs.Customer;
using AutoMapper;
namespace Contact.Managment.MVC.Services
{
    public class CustomerService :BaseHttpService ,  ICustomerService
    {
        private readonly Mapper _mapper;
        private readonly ILocalStorageService _localStorage;
        private readonly IClient _httpClient;
        public CustomerService(Mapper mapper, ILocalStorageService localStorage, IClient httpClient):base(httpClient,localStorage)
        {
            _mapper = mapper;
            _localStorage = localStorage;
            _httpClient = httpClient;

        }
        public  async Task<Response<int>> CreateCustomer(CreateCustomerVM customer)
        {
            try
            {
                var response = new Response<int>();
                CreateCustomerDto createCustomer = _mapper.Map<CreateCustomerDto>(customer);
                var apiresponse = await _httpClient.CustomerPOSTAsync(createCustomer);
                if (apiresponse.Succes)
                {
                    response.Data = apiresponse.Id;
                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task DeleteCustomer(CustomerVM customer)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerVM> GetCustomerDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerVM>> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(CustomerVM customer)
        {
            throw new NotImplementedException();
        }
    }
}
