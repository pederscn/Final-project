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
    public class BreakfastFoods : ControllerBase
    {
        private static readonly string[] Fruits = new[]
        {
            "Apples","Pears","Oranges","Watermelon","Bananas"
        };
        private static readonly string[] Pastries = new[]
        {
            "Bread","Croissant","Donuts","Danish","Kringle"
        };
        private static readonly string[] Meats = new[]
        {
            "Bacon","Sausage","Ham","Turkey","Corned Beef"
        };
        private static readonly string[] TypesOfEggs = new[]
        {
            "Scrambled","Over Easy","SunnySide Up","Poached","Boiled"
        };
        private static readonly string[] Entrees = new[]
        {
            "Omelette","Pancakes","Toast","Yogurt","HashBrowns"
        };

        private readonly ILogger<BreakfastFoods> _logger;

        public BreakfastFoods(ILogger<BreakfastFoods> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BreakfastFoods> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new BreakfastFoods
            {
            
                Fruits = Fruits[rng.Next(Fruits.Length)],
                Pastries = Pastries[rng.Next(Pastries.Length)],
                Meats = Meats[rng.Next(Meats.Length)],
                TypesOfEggs = TypesOfEggs[rng.Next(TypesOfEggs.Length)],
                Entrees = Entrees[rng.Next(Entrees.Length)]
            })
            .ToArray();
        }
    }
}