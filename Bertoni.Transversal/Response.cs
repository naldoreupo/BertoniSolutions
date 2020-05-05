using System;
using System.Collections.Generic;
using System.Text;

namespace Bertoni.Transversal
{
    public class Response<TEntity>
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        public TEntity Data { get; set; }

        public IEnumerable<TEntity> List { get; set; }
    }
}
