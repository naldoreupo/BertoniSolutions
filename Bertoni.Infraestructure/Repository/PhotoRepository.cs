using Bertoni.Infraestructure.Interface;
using Bertoni.Service.Entity;
using Bertoni.Transversal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.Infraestructure.Repository
{
    public class PhotoRepository : InterfacePhotoRepository<PhotoOutputModel>
    {
        public async Task<Response<PhotoOutputModel>> GetFiltered(int albumId)
        {
            IEnumerable<PhotoOutputModel> albums;

            using (var client = new HttpClient())
            {
                var baseUrl = "https://jsonplaceholder.typicode.com/photos?albumId=";
                var url = String.Concat(baseUrl, albumId);
                var content = await client.GetStringAsync(url);
                albums = JsonConvert.DeserializeObject<IEnumerable<PhotoOutputModel>>(content);
            }

            return new Response<PhotoOutputModel>() { Status = true, Message = "albus return", List = albums };
        }
    }
}
