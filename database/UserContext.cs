using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class UserContext: DbContext
    {
        public UserContext (DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet <User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity <User>().ToTable("User");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=prueba;user=root;password=oedh960831");
        }
    }


}