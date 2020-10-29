using AutoMapper;
using My_Rent.Models;
using My_Rent.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Rent.Service.Models
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            this.CreateMap<Property, PropertyDto>().ReverseMap();
            this.CreateMap<Property, CreatePropertyDto>().ReverseMap();
            this.CreateMap<Property, UpdatePropertyDto>().ReverseMap();
            this.CreateMap<PropertyDto, PropertyViewModel>().ReverseMap();
            this.CreateMap<CreatePropertyDto, CreatePropertyViewModel>().ReverseMap();
            this.CreateMap<PropertyDto, UpdatePropertyDto>().ReverseMap();
            this.CreateMap<Property, UpdatePropertyDto>().ReverseMap();
            this.CreateMap<PropertyDto, UpdatePropertyViewModel>().ReverseMap();
            this.CreateMap<Property, UpdatePropertyViewModel>().ReverseMap();
            this.CreateMap<UpdatePropertyDto, UpdatePropertyViewModel>().ReverseMap();
            this.CreateMap<List<PropertyDto>, PropertyCategoryViewModel>().ReverseMap();
            this.CreateMap<PropertyDto, List<PropertyDto>>().ReverseMap();
            this.CreateMap<PropertyDto, PropertyCategoryViewModel>().ReverseMap();
            this.CreateMap<Property, List<PropertyDto>>().ReverseMap();

        }
    }
}
