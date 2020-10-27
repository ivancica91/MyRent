using AutoMapper;
using My_Rent.Models;

namespace My_Rent.Views.Models
{

    public class MyRentProfile : Profile
    {
        public MyRentProfile()
        {
            this.CreateMap<CreatePropertyViewModel, Property>();
            this.CreateMap<UpdatePropertyViewModel, Property>().ReverseMap();
            this.CreateMap<Property, PropertyViewModel>();
            
            
           
        }
    }
}
