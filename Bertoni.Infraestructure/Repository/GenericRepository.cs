﻿
using Number8.Exam.Infraestructure.Interface;
using System;
using System.Threading.Tasks;

namespace Number8.Exam.Infraestructure
{
    public class GenericRepository<TEntity> : InterfaceGenericRepository<TEntity> where TEntity : class
    {
        private readonly ActiveDBContext _context ;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ActiveDBContext context)
        {
            this._context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public Response<bool> GetAll(TEntity tEntity)
        {
            Response<bool> response;
            try
            {
                _context.Add(tEntity);

                response = new Response<bool>()
                {
                    Status = true,
                    Message = "Operation completed"
                };
            }
            catch (Exception ex)
            {
                response = new Response<bool>()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
            return response;
        }
    }
}
