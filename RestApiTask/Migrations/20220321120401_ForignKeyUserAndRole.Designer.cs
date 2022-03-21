﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestApiTask.Models.Data;

namespace RestApiTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220321120401_ForignKeyUserAndRole")]
    partial class ForignKeyUserAndRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("RestApiTask.Models.DemoRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ApproveRequest")
                        .HasColumnType("bit");

                    b.Property<int>("ManageRoleId")
                        .HasColumnType("int");

                    b.Property<bool>("ViewRequest")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ManageRoleId");

                    b.ToTable("demoRequests");
                });

            modelBuilder.Entity("RestApiTask.Models.ManageRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("manageRoles");
                });

            modelBuilder.Entity("RestApiTask.Models.ManageTenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ManageRoleId")
                        .HasColumnType("int");

                    b.Property<bool>("RegisterTenant")
                        .HasColumnType("bit");

                    b.Property<bool>("RessetPassword")
                        .HasColumnType("bit");

                    b.Property<bool>("UpdateTenant")
                        .HasColumnType("bit");

                    b.Property<bool>("UpgradePlan")
                        .HasColumnType("bit");

                    b.Property<bool>("ViewTenant")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ManageRoleId");

                    b.ToTable("manageTenants");
                });

            modelBuilder.Entity("RestApiTask.Models.ManageUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("CreateUser")
                        .HasColumnType("bit");

                    b.Property<bool>("Inactive")
                        .HasColumnType("bit");

                    b.Property<bool>("Reset")
                        .HasColumnType("bit");

                    b.Property<bool>("UpdateUser")
                        .HasColumnType("bit");

                    b.Property<int>("UserManagementsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserManagementsId");

                    b.ToTable("manageUsers");
                });

            modelBuilder.Entity("RestApiTask.Models.Payments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ChangeStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ManageRoleId")
                        .HasColumnType("int");

                    b.Property<bool>("ViewPayment")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ManageRoleId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("RestApiTask.Models.RolesManage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("CreateUser")
                        .HasColumnType("bit");

                    b.Property<bool>("UpdateRole")
                        .HasColumnType("bit");

                    b.Property<int>("UserManagementsId")
                        .HasColumnType("int");

                    b.Property<bool>("ViewRole")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserManagementsId");

                    b.ToTable("rolesManages");
                });

            modelBuilder.Entity("RestApiTask.Models.UserManagements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ManageRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManageRoleId");

                    b.ToTable("userManagements");
                });

            modelBuilder.Entity("RestApiTask.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("ManageRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManageRoleId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("RestApiTask.Models.DemoRequest", b =>
                {
                    b.HasOne("RestApiTask.Models.ManageRoles", "ManageRoles")
                        .WithMany("DemoRequests")
                        .HasForeignKey("ManageRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageRoles");
                });

            modelBuilder.Entity("RestApiTask.Models.ManageTenant", b =>
                {
                    b.HasOne("RestApiTask.Models.ManageRoles", "ManageRoles")
                        .WithMany("ManageTenants")
                        .HasForeignKey("ManageRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageRoles");
                });

            modelBuilder.Entity("RestApiTask.Models.ManageUsers", b =>
                {
                    b.HasOne("RestApiTask.Models.UserManagements", "UserManagements")
                        .WithMany("manageUsers")
                        .HasForeignKey("UserManagementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserManagements");
                });

            modelBuilder.Entity("RestApiTask.Models.Payments", b =>
                {
                    b.HasOne("RestApiTask.Models.ManageRoles", "ManageRoles")
                        .WithMany("Payments")
                        .HasForeignKey("ManageRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageRoles");
                });

            modelBuilder.Entity("RestApiTask.Models.RolesManage", b =>
                {
                    b.HasOne("RestApiTask.Models.UserManagements", "UserManagements")
                        .WithMany("rolesManages")
                        .HasForeignKey("UserManagementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserManagements");
                });

            modelBuilder.Entity("RestApiTask.Models.UserManagements", b =>
                {
                    b.HasOne("RestApiTask.Models.ManageRoles", "ManageRoles")
                        .WithMany("UserManagements")
                        .HasForeignKey("ManageRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageRoles");
                });

            modelBuilder.Entity("RestApiTask.Models.Users", b =>
                {
                    b.HasOne("RestApiTask.Models.ManageRoles", "ManageRoles")
                        .WithMany()
                        .HasForeignKey("ManageRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManageRoles");
                });

            modelBuilder.Entity("RestApiTask.Models.ManageRoles", b =>
                {
                    b.Navigation("DemoRequests");

                    b.Navigation("ManageTenants");

                    b.Navigation("Payments");

                    b.Navigation("UserManagements");
                });

            modelBuilder.Entity("RestApiTask.Models.UserManagements", b =>
                {
                    b.Navigation("manageUsers");

                    b.Navigation("rolesManages");
                });
#pragma warning restore 612, 618
        }
    }
}
