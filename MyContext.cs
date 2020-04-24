using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationTests
{
    public class MyContext : DbContext
    {
        public DbSet<MyEntity> MyEntities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoContext;Trusted_Connection=True;MultipleActiveResultSets=true");

            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseInMemoryDatabase("TodoContext");
            //}

            //base.OnConfiguring(optionsBuilder);
        }
    }
}
