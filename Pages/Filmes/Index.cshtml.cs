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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFimes.Data.RazorPagesFimesContext _context;

        public IndexModel(RazorPagesFimes.Data.RazorPagesFimesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Filme = await _context.Filme.ToListAsync();
        }
    }
}
