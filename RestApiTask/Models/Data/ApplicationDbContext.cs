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
        public DbSet<ManageUsers> manageUsers { get; set; }
        public DbSet<RolesManage> rolesManages { get; set; }
        public DbSet<UserManagements> userManagements { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payments>()
           .HasOne(p => p.ManageRoles)
           .WithMany(b => b.Payments)
           .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ManageTenant>()
          .HasOne(p => p.ManageRoles)
          .WithMany(b => b.ManageTenants)
          .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<DemoRequest>()
          .HasOne(p => p.ManageRoles)
          .WithMany(b => b.DemoRequests)
          .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ManageUsers>()
         .HasOne(p => p.UserManagements)
         .WithMany(b => b.manageUsers)
         .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<RolesManage>()
         .HasOne(p => p.UserManagements)
         .WithMany(b => b.rolesManages)
         .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserManagements>()
         .HasOne(p => p.ManageRoles)
         .WithMany(b => b.UserManagements)
         .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserRoles>()
                .HasKey(ur => new { ur.RoleId, ur.UserId });
            modelBuilder.Entity<UserRoles>()
                .HasOne(ur => ur.Users)
                .WithMany(ur => ur.ManagRoles)
       
      //      modelBuilder.Entity<Payments>()
      //                .HasOne(p => p.ManageRoles)
      //                .WithMany(b => b.Payments)
      //              .OnDelete(DeleteBehavior.Cascade);

            //        modelBuilder.Entity<ManageTenant>()
            //        .HasOne(p => p.ManageRoles)
            //       .WithMany(b => b.ManageTenants)
            //       .OnDelete(DeleteBehavior.Cascade);


            //      modelBuilder.Entity<DemoRequest>()
            //    .HasOne(p => p.ManageRoles)
            //    .WithMany(b => b.DemoRequests)
            //       .OnDelete(DeleteBehavior.Cascade);

            //          modelBuilder.Entity<ManageUsers>()
            //    .HasOne(p => p.UserManagements)
            //    .WithMany(b => b.manageUsers)
            //      .OnDelete(DeleteBehavior.Cascade);

            //      modelBuilder.Entity<RolesManage>()
            // .HasOne(p => p.UserManagements)
            // .WithMany(b => b.rolesManages)
            // .OnDelete(DeleteBehavior.Cascade);

            //      modelBuilder.Entity<UserManagements>()
            //.HasOne(p => p.ManageRoles)
            //.WithMany(b => b.UserManagements)
            //.OnDelete(DeleteBehavior.Cascade);
        }
    }
}
