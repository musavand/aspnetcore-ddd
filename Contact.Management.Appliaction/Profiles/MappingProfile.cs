using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Domain;

namespace Contact.Management.Appliaction.Profiles
{
    public class MappingProfile : Profile
    {
        //ctor
        //map domain obj ---- dto object
        //base for mapping is DTO object
        //dto limits number of domain entity field for users
        public MappingProfile()
        {
            #region Customer
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            #endregion Customer
        }
    }
}