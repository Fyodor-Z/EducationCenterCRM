using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.Models;
using Microsoft.EntityFrameworkCore;

namespace EducationCenterCRM.Database
{
    public class ApplicationContext: DbContext

    {
        public DbSet<Student> Students { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
