using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Transversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Infraestructure.Interface
{

    public interface InterfaceAlbumRepository<TEntity> where TEntity : class
    {
        Task<Response<AlbumDTO>> GetAll();
    }

}
