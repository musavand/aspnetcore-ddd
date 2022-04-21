using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Managment.MVC.Models;
//using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Managment.MVC.Services.Base;

namespace Contact.Managment.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerDto, CreateCustomerVM>().ReverseMap();
            CreateMap<CustomerDto , CustomerVM>().ReverseMap();
        }
    }
}
