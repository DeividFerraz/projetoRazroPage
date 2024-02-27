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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesFimes.Data.RazorPagesFimesContext _context;

        public DeleteModel(RazorPagesFimes.Data.RazorPagesFimesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme.FindAsync(id);
            if (filme != null)
            {
                Filme = filme;
                _context.Filme.Remove(Filme);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
