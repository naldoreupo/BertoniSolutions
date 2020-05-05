using Bertoni.Transversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Number8.Exam.Infraestructure.Interface
{
    public interface InterfaceGenericRepository<TEntity> where TEntity : class
    {
        Response<bool> GetAll();
    }
}
