using AutoMapper;
using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bertoni.Transversal
{
    public static class Maps
    {
        public static IMapper InitMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Response<AlbumDTO>, Response<AlbumOutputModel>>()
                  .ForMember(dest => dest.List, opt => opt.MapFrom(src => src.List))
                  .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message));
    
                cfg.CreateMap<Response<AlbumOutputModel>, Response<AlbumDTO>>()
                  .ForMember(dest => dest.List, opt => opt.MapFrom(src => src.List))
                  .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message));

                cfg.CreateMap<AlbumDTO, AlbumOutputModel>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                  .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

                cfg.CreateMap<AlbumOutputModel, AlbumDTO>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                  .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

                cfg.CreateMap<IEnumerable<AlbumDTO>, IEnumerable<AlbumOutputModel>>();
                cfg.CreateMap<IEnumerable<AlbumOutputModel>, IEnumerable<AlbumDTO>>();
            });

            return config.CreateMapper();
        }
    }
}
