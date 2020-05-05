using Bertoni.Domain.Entity;
using Bertoni.Infraestructure.Entity;
using Bertoni.Infraestructure.Interface;
using Bertoni.Service.Entity;
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
    public class AlbumRepository : InterfaceAlbumRepository<AlbumOutputModel>
    {
        HttpClient client = new HttpClient();

        public async Task<Response<AlbumOutputModel>> GetAll()
        {
            IEnumerable<AlbumOutputModel> albums ;

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
                albums = JsonConvert.DeserializeObject<IEnumerable<AlbumOutputModel>>(content);
            }

            return new Response<AlbumOutputModel>() { Status = true, Message = "albus return" , List =albums };
        }
    }
}
