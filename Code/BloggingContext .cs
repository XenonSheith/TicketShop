using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TicketShop.Code
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            Database.AutoTransactionsEnabled = true;
        }
        public DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }
    }

    public class Test
    {
        public int Id {get;set;}
        public string Title {get;set;}
    }
}