using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UsedCars.Data;
using UsedCars.Model;

namespace UsedCars
{
    public class IndexModel : PageModel
    {
        private readonly UsedCars.Data.UsedCarsContext _context;

        public IndexModel(UsedCars.Data.UsedCarsContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Cars.ToListAsync();
        }
    }
}
