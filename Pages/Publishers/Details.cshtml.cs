using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Odobas_Tudor_Lab8.Data;
using Odobas_Tudor_Lab8.Models;

namespace Odobas_Tudor_Lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Odobas_Tudor_Lab8.Data.Odobas_Tudor_Lab8Context _context;

        public DetailsModel(Odobas_Tudor_Lab8.Data.Odobas_Tudor_Lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
