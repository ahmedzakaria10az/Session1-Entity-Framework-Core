using Microsoft.EntityFrameworkCore;
using Session1_Entity_Framework_Core.Contexts;

namespace Session1_Entity_Framework_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
          using BookStoreDbContext dbContext = new BookStoreDbContext();

            dbContext.Database.Migrate();
        }
    }
}
