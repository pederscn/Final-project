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
    public class TeamMemberInfoController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Christian Pedersen"
        };
        private static readonly DateTime[] Birthdate = new[]
        {
            "May 22nd, 2002"
        };
        private static readonly string[] CollegeProgram = new[]
        {
            "Information Technology","Cyber Security"
        };
        private static readonly string[] YearInProgram = new[]
        {
            "Sophomore"
        };

        private readonly ILogger<TeamMemberInfoController> _logger;

        public TeamMemberInfoController(ILogger<TeamMemberInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TeamMemberInfoController> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TeamMemberInfo
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}