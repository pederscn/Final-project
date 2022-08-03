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
    public class Hobbies : ControllerBase
    {
        private static readonly string[] AthleticHobbies = new[]
        {
            "Baseball","Lifting","Basketball","Cycling","Bowling"
        };
        private static readonly string[] ArtHobbies = new[]
        {
            "Pottery","Painting","Sewing","WoodWork","Drawing"
        };
        private static readonly string[] HobbiesWithFriends = new[]
        {
            "Rock Climbing","Watching Football","Playing Football","Cooking","Party"
        };
        private static readonly string[] EducationalHobbies = new[]
        {
            "Astronomy","Geography","Physics","Research","Teaching"
        };
        private static readonly string[] CollectionHobbies = new[]
        {
            "Antiques","Dolls","Films","Shoes","Vinyls"
        };

        private readonly ILogger<Hobbies> _logger;

        public Hobbies(ILogger<Hobbies> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Hobbies> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Hobbies
            {
            
                AthleticHobbies = AthleticHobbies[rng.Next(AthleticHobbies.Length)],
                ArtHobbies = ArtHobbies[rng.Next(ArtHobbies.Length)],
                HobbiesWithFriends = HobbiesWithFriends[rng.Next(HobbiesWithFriends.Length)],
                EducationalHobbies = EducationalHobbies[rng.Next(EducationalHobbies.Length)],
                CollectionHobbies = CollectionHobbies[rng.Next(CollectionHobbies.Length)]
            })
            .ToArray();
        }
    }
}