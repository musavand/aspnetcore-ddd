using Contact.Managment.MVC.Contracts;
using Contact.Managment.MVC.Models;
using Contact.Managment.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Contact.Management.Appliaction.DTOs.Customer;
using AutoMapper;
namespace Contact.Managment.MVC.Services
{
    public class CustomerService :BaseHttpService ,  ICustomerService
    {
        private readonly Mapper _mapper;
        private readonly ILocalStorageService _localStorage;
        private readonly IClient _httpClient;
        public CustomerService(Mapper mapper, Client httpClient, ILocalStorageService localStorage):base(httpClient,localStorage)
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
                CreateCustomerDto createCustomerDto = _mapper.Map<CreateCustomerDto>(customer);
                var apiResponse=await _client.CustomerPOSTAsync(createCustomerDto);
                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach (var error in apiResponse.Errors)
                    {
                        response.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return response;
            }
            catch (ApiException exp)
            {

                return ConvertApiExecptions<int>(exp);
            }
            
        }

        public  async Task<Response<int>> DeleteCustomer(int id)
        {
            try
            {
                await _client.CustomerDELETEAsync(id);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExecptions<int>(ex);
            }
        }

        

        public async Task<CustomerVM> GetCustomerDetail(int id)
        {
            var customer = await _client.CustomerGETAsync(id);
            return _mapper.Map<CustomerVM>(customer);
        }

        public async Task<List<CustomerVM>> GetCustomers()
        {
            var customers = await _client.CustomerAllAsync();
            return _mapper.Map<List<CustomerVM>>(customers);

        }

        public  async Task<Response<int>> UpdateCustomer(int id,CustomerVM customer)
        {
            try
            {
                CreateCustomerDto customerDto = _mapper.Map<CreateCustomerDto>(customer);
                await _client.CustomerPUTAsync(customerDto);
                return new Response<int>() { Success = true };


            }
            catch (ApiException  exp)
            {

                return ConvertApiExecptions<int>(exp);
            }
        }

        
    }
}
