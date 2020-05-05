using AutoMapper;
using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Infraestructure.Interface;
using Bertoni.Transversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Domain
{
    public class AlbumDomain : InterfaceAlbumDomain
    {
        private readonly InterfaceAlbumRepository<AlbumDTO> _albumRepository;

        public AlbumDomain(InterfaceAlbumRepository<AlbumDTO> albumRepository)
        {
            this._albumRepository = albumRepository;
        }


        public async Task<Response<AlbumDTO>> getAll()
        {
            return await this._albumRepository.GetAll();
        }
    }
}
