using AutoMapper;
using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Service.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bertoni.Transversal
{
    public static class Maps
    {
        public static IMapper InitMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Album, AlbumDTO>();
                cfg.CreateMap<AlbumDTO, Album>();

                cfg.CreateMap<Response<Album>, Response<AlbumDTO>>();
                cfg.CreateMap<Response<AlbumDTO>, Response<Album>>();

                cfg.CreateMap< List<Album>, List<AlbumDTO>>();
                cfg.CreateMap< List<AlbumDTO>, List<Album>>();

                cfg.CreateMap<AlbumDTO, AlbumOutputModel>();
                cfg.CreateMap<AlbumOutputModel, AlbumDTO>();

                cfg.CreateMap<List<AlbumDTO>, List<AlbumOutputModel>>();
                cfg.CreateMap< List<AlbumOutputModel>, List<AlbumDTO>>();
            });

            return config.CreateMapper();
        }
    }
}
