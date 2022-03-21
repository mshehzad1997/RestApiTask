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
       
        public DbSet<Payments> Payments { get; set; }
        public DbSet<ManageTenant> manageTenants { get; set; }
        public DbSet<DemoRequest> demoRequests { get; set; }
        public DbSet<ManageUsers> manageUsers { get; set; }
        public DbSet<RolesManage> rolesManages { get; set; }
        public DbSet<UserManagements> userManagements { get; set; }
    }
}
