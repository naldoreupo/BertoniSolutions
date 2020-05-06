using System;
using System.Collections.Generic;
using System.Text;

namespace Bertoni.Service.Entity
{
   public class CommentOutputModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
