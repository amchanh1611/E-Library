using Microsoft.EntityFrameworkCore;

namespace E_Library.Models
{
    public class E_LibraryDbContext : DbContext
    {
        public E_LibraryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<PrivateFile> PrivateFiles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<OTP> OTPs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<PermistionRole>().HasKey(y => new { y.RoleId, y.PermisstionId });
            modelBuilder.Entity<User>().HasIndex(z=>z.Email).IsUnique();
        }
    }
}