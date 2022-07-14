using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_MVC.Models
{
    public class TermContext : DbContext
    {
        public TermContext (DbContextOptions<TermContext> options) : base(options) { }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chapter>().HasData(
               new Chapter { ChapterId = "I", Name = "Introduction" },
               new Chapter { ChapterId = "s", Name = "single" },
               new Chapter { ChapterId = "B", Name = "Bootstrap" },
               new Chapter { ChapterId = "d", Name = "data-driven" },
               new Chapter { ChapterId = "t", Name = "testing" },
               new Chapter { ChapterId = "c", Name = "controllers" },
               new Chapter { ChapterId = "R", Name = "Razor" }
           );

            modelBuilder.Entity<Term>().HasData(
                new Term
                {
                    TermId = 4,
                    TermName = "web app",
                    Page = 33,
                    Stage = 1,
                    ChapterId = "R"
                },
                new Term
                {
                    TermId = 3,
                    TermName = "local area network (LAN)",
                    Page = 33,
                    Stage = 1,
                    ChapterId = "c"
                },
                new Term
                {
                    TermId = 2,
                    TermName = "URL (Uniform Resource Locator)",
                    Page = 33,
                    Stage = 1,
                    ChapterId = "t"
                }
            );
        }

    }
}
