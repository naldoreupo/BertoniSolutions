using Microsoft.EntityFrameworkCore;
using Number8.Exam.Infraestructure.Entity;
using Number8.Exam.Infraestructure.Interface;
using Number8.Exam.Infraestructure.Models;
using System.Threading.Tasks;

namespace Number8.Exam.Infraestructure
{
    public class UnitOfWork : InterfaceUnitOfWork
    {
        private readonly ActiveDBContext _context;
        private InterfaceGenericRepository<Album> _productRepository;
        public UnitOfWork(ActiveDBContext context) 
        {
            _context = context;
        }
        public InterfaceGenericRepository<Album> AlbumRepository
        {
            get
            {
                return _albumRepository ??
                    (_productRepository = new GenericRepository<Album>(_context));
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
