using Bertoni.Infraestructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Number8.Exam.Infraestructure.Interface
{
    public interface InterfaceUnitOfWork
    {
        InterfaceGenericRepository<Album> AlbumRepository { get; }
        Task GetAll();
    }
}
