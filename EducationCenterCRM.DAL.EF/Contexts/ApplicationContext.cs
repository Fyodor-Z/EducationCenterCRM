using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL.EF;

using Microsoft.EntityFrameworkCore;

namespace EducationCenterCRM.DAL.EF.Contexts
{
    public class ApplicationContext : DbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<StudentGroup> StudentGroups { get; set; }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EducCentrCRMDb;Trusted_Connection=True;");
        }


    }
}
