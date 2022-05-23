using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EFrameworkCodeFirst.Lesson
{
    public class CorsoDbContext : DbContext
    {

        public CorsoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BlogDbContextDatabase"].ConnectionString);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=CorsoDb; User id = sa ; password = Pass@word01;Trusted_Connection=False");
        }
     
        public DbSet<Corso> Corso { get; set; }
        public DbSet<Post> Post { get; set; }

    }

   }
