using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace repos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballTeamsController : ControllerBase
    {


        private readonly ILogger<FootballTeamsController> _logger;
        private readonly FootballTeamsContext _context;

        public FootballTeamsController(ILogger<FootballTeamsController> logger, FootballTeamsContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FootballTeams.ToList());
        }
    }
}
