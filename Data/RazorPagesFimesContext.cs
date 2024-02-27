using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFimes.Modelo;

namespace RazorPagesFimes.Data
{
    public class RazorPagesFimesContext : DbContext
    {
        public RazorPagesFimesContext (DbContextOptions<RazorPagesFimesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFimes.Modelo.Filme> Filme { get; set; } = default!;
    }
}
