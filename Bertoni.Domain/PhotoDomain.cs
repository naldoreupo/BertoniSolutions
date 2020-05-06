using Bertoni.Infraestructure.Interface;
using Bertoni.Service.Entity;
using Bertoni.Transversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Domain
{
    public class PhotoDomain : InterfacePhotoDomain
    {
        private readonly InterfacePhotoRepository<PhotoOutputModel> _photoRepository;

        public PhotoDomain(InterfacePhotoRepository<PhotoOutputModel> photoRepository)
        {
            this._photoRepository = photoRepository;
        }
        public async Task<Response<PhotoOutputModel>> GetFiltered(int albumId)
        {
            return await _photoRepository.GetFiltered(albumId);
        }
    }
}
