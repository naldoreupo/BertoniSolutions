using Bertoni.Service.Entity;
using Bertoni.Transversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Domain
{
    public interface InterfacePhotoDomain
    {
        Task<Response<PhotoOutputModel>> GetFiltered(int albumId);
    }
}
