using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bertoni.Domain;
using Bertoni.Domain.Entity;
using Bertoni.Service.Entity;
using Bertoni.Transversal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bertoni.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly InterfaceAlbumDomain _albumDomain;

        public AlbumController(IMapper mapper, InterfaceAlbumDomain albumDomain)
        {
            this._albumDomain = albumDomain;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<Response<AlbumOutputModel>> Get(int id)
        {
            return await _albumDomain.getAll();
        }
    }
}
