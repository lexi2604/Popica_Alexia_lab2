using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popica_Alexia_lab2.Models;

namespace Popica_Alexia_lab2.Data
{
    public class Popica_Alexia_lab2Context : DbContext
    {
        public Popica_Alexia_lab2Context (DbContextOptions<Popica_Alexia_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Popica_Alexia_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Popica_Alexia_lab2.Models.Publisher> Publisher { get; set; }
    }
}
