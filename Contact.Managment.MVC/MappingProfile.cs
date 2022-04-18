using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Managment.MVC.Models;
using Contact.Management.Appliaction.DTOs.Customer;

namespace Contact.Managment.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CraeteMap<CreateCustomerDto, CreateCustomerVM>().ReverseMap();
            CraeteMap<CustomerDto , CustomerVM>().ReverseMap();
        }
    }
}
