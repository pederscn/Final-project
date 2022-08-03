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
    public class BasketballTeams : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Bucks","Bulls","Cavaliers","Lakers","Heat"
        };
        private static readonly string[] Titles = new[]
        {
            "2","5","2","17","2"
        };
        private static readonly string[] Cities = new[]
        {
            "Milwaukee","Chicago","Cleveland","Los Angeles","Miami"
        };
        private static readonly string[] BestPlayer = new[]
        {
            "Giannis Antetokoumpo","Zach Lavine","Darius Garland","Lebron James","Jimmy Butler"
        };
        private static readonly string[] MainColor = new[]
        {
            "Green","Red","Maroon","Yellow","Red"
        };

        private readonly ILogger<BasketballTeams> _logger;

        public BasketballTeams(ILogger<BasketballTeams> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BasketballTeams> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new BasketballTeams
            {
            
                Names = Names[rng.Next(Names.Length)],
                Titles = Titles[rng.Next(Titles.Length)],
                Cities = Cities[rng.Next(Cities.Length)],
                BestPlayer = BestPlayer[rng.Next(Bestplayer.Length)],
                MainColor = MainColor[rng.Next(MainColor.Length)]
            })
            .ToArray();
        }
    }
}