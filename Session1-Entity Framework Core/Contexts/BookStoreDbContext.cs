using Microsoft.EntityFrameworkCore;
using Session1_Entity_Framework_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session1_Entity_Framework_Core.Contexts
{
    internal class BookStoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Server=.;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
