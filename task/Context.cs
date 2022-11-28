using Microsoft.EntityFrameworkCore;
namespace task
{
    public class Context :DbContext
    {
        public Context()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-HKF1UMM\\SQLEXPRESS; Database=Test2; User Id=user1; Password=user1; MultipleActiveResultSets=true; TrustServerCertificate=True") ;
        }
        public DbSet<BasicList> basicLists { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
