using AutoMapper;
using ChecklistApp.API.Dtos;
using ChecklistApp.API.Models;

namespace ChecklistApp.API.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailDto>();
            CreateMap<Client, ClientForListDto>();
        }
    }
}