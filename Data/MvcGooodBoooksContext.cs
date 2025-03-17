using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcGooodBoooks.Models;

namespace MvcGooodBoooks.Data
{
    public class MvcGooodBoooksContext : DbContext
    {
        public MvcGooodBoooksContext (DbContextOptions<MvcGooodBoooksContext> options)
            : base(options)
        {
        }
        public DbSet<MvcGooodBoooks.Models.Reader> Reader { get; set; } = default!;
        public DbSet<MvcGooodBoooks.Models.Author> Author { get; set; } = default!;
        public DbSet<MvcGooodBoooks.Models.Book> Book { get; set; } = default!;
        public DbSet<MvcGooodBoooks.Models.Review> Review { get; set; } = default!;

        
    }

    
}
