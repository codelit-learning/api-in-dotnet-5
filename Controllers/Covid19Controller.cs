using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vid19.Services;
using vid19.Models;

namespace vid19.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Covid19Controller : ControllerBase
    {
        private readonly Covid19Service _covid19Service;

        public Covid19Controller(Covid19Service covid19Service)
        {
            _covid19Service = covid19Service;
        }

        [HttpGet]
        public async Task<ActionResult<Stats>> World()
        {
            return await _covid19Service.GetWorldStats();
        }
    }
}