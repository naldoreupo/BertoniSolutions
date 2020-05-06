using System;
using System.Collections.Generic;
using System.Text;

namespace Bertoni.Service.Entity
{
    public class PhotoOutputModel
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }

    }
}
