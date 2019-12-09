using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsedCars.Data;
using UsedCars.Model;

namespace UsedCars.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Car[] Cars { get; set; } = new Car[] {
           /* new Car("volvo", 23000, "rood", 2017),
            new Car("volvo", 28000, "zwart", 2018),
            new Car("volvo", 25000, "grijs", 2017),
            new Car("audi", 35000, "grijs", 2017),
            new Car("audi", 30000, "rood", 2015),
            new Car("renault", 18000, "blauw", 2015),
            new Car("nissan", 21000, "blauw", 2016),*/
        };

        private readonly UsedCarsContext db;

        [BindProperty]
        public string MaximumPriceString { get; set; } = "";

        [BindProperty]
        public string Color { get; set; } = "";

        [BindProperty]
        public string Type { get; set; } = "";

        [BindProperty]
        public string Kilometers { get; set; } = "";

        public IndexModel(ILogger<IndexModel> logger, UsedCarsContext dataB)
        {
            _logger = logger;
            /********** add db *************/
            this.db = dataB;
            /********** add db *************/
        }

        public string[] UniqueColorsForCars()
        {
            HashSet<string> colorSet = new HashSet<string>();
            foreach (Car car in Cars)
            {
                colorSet.Add(car.Color);
            }
            return colorSet.ToArray();
        }

        public bool IsCarSelected(Car car)
        {
            if (!String.IsNullOrEmpty(MaximumPriceString) && car.Price > Convert.ToInt32(MaximumPriceString)) return false;
            if (!String.IsNullOrEmpty(Color) && car.Color != Color) return false;
            if (!String.IsNullOrEmpty(Type) && car.Name != Type) return false;

            return true;
        }

        private Car[] filter()
        {
            Car[] filteredCars = new Car[] { };

            return filteredCars;
        }

        // public void OnGet()
        public async Task OnGetAsync()
        {
            //See https://www.learnrazorpages.com/razor-pages/tutorial/bakery/working-with-data  retrieve data for display on the home page

            var CarsList = await db.Cars.ToListAsync();
            Cars = CarsList.ToArray();
        }

        // public void OnPost()
        public async Task OnPostAsync()
        {
            var CarsList = await db.Cars.ToListAsync();
            Cars = CarsList.ToArray();
        }
    }
}