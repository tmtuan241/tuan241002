using AutoMapper;
using Infrastructure.Entities;
using DPM205488_LMT.Models;

namespace DPM205488_LMT
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<GiayDep, GiayDepViewModel>();
            CreateMap<GiayDepViewModel, GiayDep>();
        }
    }
}
