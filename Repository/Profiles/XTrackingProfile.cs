using AutoMapper;
using Modelo;
using Modelo.Dto;
using Modelo.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Profiles
{
    public class XTrackingProfile : Profile
    {
        public XTrackingProfile()
        {
            CreateMap<Placa, PlacaDto>().ReverseMap();
            CreateMap<HistoricoLocalizacao, HistoricoLocalizacaoDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}
