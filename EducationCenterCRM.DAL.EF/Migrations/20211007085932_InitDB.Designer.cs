﻿// <auto-generated />
using System;
using EducationCenterCRM.DAL.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EducationCenterCRM.DAL.EF.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211007085932_InitDB")]
    partial class InitDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb96f6c2-ac27-40e9-8e8a-ac3eda194e4b"),
                            BirthDate = new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vasilii",
                            Gender = 0,
                            LastName = "Petrov",
                            StartDate = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2")
                        },
                        new
                        {
                            Id = new Guid("24223ec9-8eff-4f19-bbea-62c00510cae0"),
                            BirthDate = new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Petr",
                            Gender = 0,
                            LastName = "Vasiliev",
                            StartDate = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2")
                        },
                        new
                        {
                            Id = new Guid("2e793b75-0867-425c-a9d5-80e78f5150b9"),
                            BirthDate = new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan",
                            Gender = 0,
                            LastName = "Bezfamilnyi",
                            StartDate = new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6")
                        },
                        new
                        {
                            Id = new Guid("36300be9-9f8c-4dd7-a7d0-c35700829ac9"),
                            BirthDate = new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mariya",
                            Gender = 1,
                            LastName = "Sidorova",
                            StartDate = new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6")
                        },
                        new
                        {
                            Id = new Guid("e733ec95-12aa-4c1e-8308-f61fcffa3a1b"),
                            BirthDate = new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vitali",
                            Gender = 0,
                            LastName = "Lukyanov",
                            StartDate = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e")
                        },
                        new
                        {
                            Id = new Guid("0f1d6a47-5778-462d-a242-a7bd347ea65e"),
                            BirthDate = new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Elvira",
                            Gender = 0,
                            LastName = "Zaytseva",
                            StartDate = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e")
                        });
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.StudentGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentGroups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2"),
                            TeacherId = new Guid("30bfad55-973f-404f-b5e5-80d5b06f2079"),
                            Title = "ASP_21-1"
                        },
                        new
                        {
                            Id = new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6"),
                            TeacherId = new Guid("cdc235b1-d4f1-4d71-a48b-28f4fe8d0d77"),
                            Title = "ASP_21-2"
                        },
                        new
                        {
                            Id = new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e"),
                            TeacherId = new Guid("91c79154-a504-4e24-a69f-bff96088b090"),
                            Title = "JS_21-1"
                        });
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkToProfile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30bfad55-973f-404f-b5e5-80d5b06f2079"),
                            Bio = "Some information",
                            BirthDate = new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Petr",
                            Gender = 0,
                            LastName = "Reshetnikov",
                            LinkToProfile = "https://www.linkedin.com/feed/"
                        },
                        new
                        {
                            Id = new Guid("cdc235b1-d4f1-4d71-a48b-28f4fe8d0d77"),
                            Bio = "Some other information",
                            BirthDate = new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mikhail",
                            Gender = 0,
                            LastName = "Andreev",
                            LinkToProfile = "https://www.linkedin.com/feed/"
                        },
                        new
                        {
                            Id = new Guid("91c79154-a504-4e24-a69f-bff96088b090"),
                            Bio = "Some other information",
                            BirthDate = new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Natalia",
                            Gender = 1,
                            LastName = "Usovich",
                            LinkToProfile = "https://www.linkedin.com/feed/"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Student", b =>
                {
                    b.HasOne("EducationCenterCRM.BLL.Models.StudentGroup", "StudentGroup")
                        .WithMany("Students")
                        .HasForeignKey("StudentGroupId");

                    b.Navigation("StudentGroup");
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.StudentGroup", b =>
                {
                    b.HasOne("EducationCenterCRM.BLL.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.StudentGroup", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
