using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
           
        }
        public DbSet<ManageRoles> manageRoles { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<ManageTenant> manageTenants { get; set; }
        public DbSet<DemoRequest> demoRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
