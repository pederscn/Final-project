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
    public class CollegeEssentials : ControllerBase
    {
        private static readonly string[] Bedding = new[]
        {
            "Pillows","Blanket","Mattress Cover","Mattress Topper","Lamp"
        };
        private static readonly string[] Computer = new[]
        {
            "Laptop","Keyboard","Mouse","Mousepad","Monitor"
        };
        private static readonly string[] SchoolSupplies = new[]
        {
            "Pencils","Pen","Notebooks","Sticky Notes","Binders"
        };
        private static readonly string[] GeneralStuff = new[]
        {
            "Fan","Vaccum","Broom","Dustpan","Chair"
        };
        private static readonly string[] Storage = new[]
        {
            "Bins","Dresser","Desk","Compartments","Laundry Bin"
        };

        private readonly ILogger<CollegeEssentials> _logger;

        public CollegeEssentials(ILogger<CollegeEssentials> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CollegeEssentials> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CollegeEssentials
            {
            
                Bedding = Bedding[rng.Next(Bedding.Length)],
                Computer = Computer[rng.Next(Computer.Length)],
                SchoolSupplies = SchoolSupplies[rng.Next(SchoolSupplies.Length)],
                GeneralStuff = GeneralStuff[rng.Next(GeneralStuff.Length)],
                Storage = Storage[rng.Next(Storage.Length)]
            })
            .ToArray();
        }
    }
}