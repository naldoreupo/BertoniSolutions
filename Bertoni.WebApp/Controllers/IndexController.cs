using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bertoni.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Bertoni.WebApp.Controllers
{
    public class IndexController : Controller
    {
        private readonly IMapper _mapper;
        private readonly InterfaceAlbumDomain _albumDomain;

        public IndexController(IMapper mapper, InterfaceAlbumDomain albumDomain)
        {
            this._albumDomain = albumDomain;
            this._mapper = mapper;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var result =  await _albumDomain.getAll();
            return View(result);
        }
    }
}