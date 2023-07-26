using AutoMapper;
using Modelo;
using Modelo.Dto;
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
        }
    }
}
