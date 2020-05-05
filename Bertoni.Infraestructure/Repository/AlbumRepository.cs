using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Infraestructure.Interface;
using Bertoni.Transversal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bertoni.Infraestructure.Repository
{
    public class AlbumRepository : InterfaceAlbumRepository<AlbumDTO>
    {
        HttpClient client = new HttpClient();

        public async Task<Response<AlbumDTO>> GetAll()
        {
            List<AlbumDTO> albums = new List<AlbumDTO>();

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
                albums = JsonConvert.DeserializeObject<List<AlbumDTO>>(content);
            }

            return new Response<AlbumDTO>() { Status = true, List =albums };
        }
    }
}
