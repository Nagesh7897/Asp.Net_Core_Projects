using Microsoft.EntityFrameworkCore;

namespace StudentOnboarding.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        { 

        }
      public DbSet<StudentDetails> Students { get; set; }
        public DbSet<StdEducationDetails> StdEducations { get; set; }
    }
}
