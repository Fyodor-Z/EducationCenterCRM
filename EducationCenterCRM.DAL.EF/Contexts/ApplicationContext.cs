using EducationCenterCRM.BLL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EducationCenterCRM.DAL.EF.Contexts
{
    public class ApplicationContext : IdentityDbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public DbSet<StudentRequest> StudentRequests { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.StudentGroup)
                .WithMany(s => s.Students)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<StudentGroup>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.StudentGroups)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Seed();
        }
    }
}
