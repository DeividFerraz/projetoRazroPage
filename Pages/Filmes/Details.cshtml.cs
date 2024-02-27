using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFimes.Data;
using RazorPagesFimes.Modelo;

namespace RazorPagesFimes.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesFimes.Data.RazorPagesFimesContext _context;

        public DetailsModel(RazorPagesFimes.Data.RazorPagesFimesContext context)
        {
            _context = context;
        }

        public Filme Filme { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme.FirstOrDefaultAsync(m => m.id == id);
            if (filme == null)
            {
                return NotFound();
            }
            else
            {
                Filme = filme;
            }
            return Page();
        }
    }
}
