using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bertoni.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bertoni.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMapper _mapper;
        private readonly InterfaceAlbumDomain _albumDomain;

        public IndexModel(ILogger<IndexModel> logger, IMapper mapper, InterfaceAlbumDomain albumDomain)
        {
            _logger = logger;
            this._albumDomain = albumDomain;
            this._mapper = mapper;
        }

        public async Task OnGetAsync()
        {
            var result = await _albumDomain.getAll();
            //return View(result);
        }
    }
}
