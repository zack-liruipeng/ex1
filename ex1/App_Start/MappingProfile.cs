using AutoMapper;
using ex1.Dtos;
using ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domian to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershiptypeDto>();
            //    Mapper.CreateMap<Movie, MovieDto>();

            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}