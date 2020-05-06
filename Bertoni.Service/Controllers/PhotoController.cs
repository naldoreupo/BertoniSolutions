using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bertoni.Domain;
using Bertoni.Service.Entity;
using Bertoni.Transversal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bertoni.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly InterfacePhotoDomain _photoDomain;

        public PhotoController(IMapper mapper, InterfacePhotoDomain photoDomain)
        {
            this._photoDomain = photoDomain;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("{albumId:int}")]
        public async Task<Response<PhotoOutputModel>> Get(int albumId)
        {
            return await _photoDomain.GetFiltered(albumId);
        }
    }
}