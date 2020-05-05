using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Service.Entity;
using Bertoni.Transversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Domain
{
    public interface InterfaceAlbumDomain
    {
        Task<Response<AlbumOutputModel>> getAll();
    }
}
