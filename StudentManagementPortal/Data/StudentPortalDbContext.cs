using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;


namespace StudentManagementPortal.Data
{
    public class StudentPortalDbContext : DbContext
    {
        private readonly DbContextOptions options;
        private readonly IAuthRepository authHandler;
        private readonly IConfiguration configuration;

        public StudentPortalDbContext(DbContextOptions options, IAuthRepository authHandler, IConfiguration configuration) : base(options)
        {
            this.options = options;
            this.authHandler = authHandler;
            this.configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ResultSubject> ResultSubjects { get; set; }
        public DbSet<LogInfo> LogInfos { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().ToTable("Users").HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Student>().ToTable("Students").HasIndex(s => s.EnrollmentId).IsUnique();
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<Result>()
                .HasOne(r => r.Student)
                .WithMany(s => s.Results)
                .HasForeignKey(r => r.StudentId);

            modelBuilder.Entity<Result>()
                .HasMany(r => r.ResultSubjects)
                .WithOne(rs => rs.Result)
                .HasForeignKey(rs => rs.ResultId);


            base.OnModelCreating(modelBuilder);
            var admins = new List<Admin>()
            {
                new Admin()
                {
                    Id = 1,
                    Name = "admin",
                    Email = "admin@email.com",
                    HashPassword = authHandler.GetHashedPassword( "admin123" ),
                    Role = "Admin",
                    Status = "Active",
                    Level = "L1"
                }
            };
            modelBuilder.Entity<Admin>().HasData(admins);
        }

    }
}
