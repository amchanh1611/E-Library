using Microsoft.EntityFrameworkCore;

namespace E_Library.Models
{
    public class E_LibraryDbContext : DbContext
    {
        public E_LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
    }
}