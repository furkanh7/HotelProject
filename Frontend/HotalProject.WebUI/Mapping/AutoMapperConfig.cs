using AutoMapper;
using HotalProject.EntityLayer.Concrete;
using HotalProject.WebUI.Dtos.LoginDto;
using HotalProject.WebUI.Dtos.RegisterDto;
using HotalProject.WebUI.Dtos.ServiceDto;

namespace HotalProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig()
        {

            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

        }
    }
}
