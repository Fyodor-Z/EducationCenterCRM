﻿// <auto-generated />
using System;
using EducationCenterCRM.DAL.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EducationCenterCRM.DAL.EF.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationWeeks")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = new Guid("31a61c86-2837-4468-ac18-a854db53ec2d"),
                            Description = "Introduction to C#",
                            DurationWeeks = 12,
                            Price = 1250m,
                            Program = "1. Getting Started",
                            Title = "Introduction to C#",
                            TopicId = new Guid("92c6afa9-bfd1-41ba-996f-14c2af30811f")
                        },
                        new
                        {
                            Id = new Guid("4e11dbdf-82e2-4a47-8768-339cc4d92bce"),
                            Description = "Introduction to Java",
                            DurationWeeks = 4,
                            Price = 1550m,
                            Program = "1. Getting Started",
                            Title = "Introduction to Web",
                            TopicId = new Guid("60ec6aae-cd23-4d55-8f9e-0179f1c69d47")
                        },
                        new
                        {
                            Id = new Guid("45e929f2-8552-4ae8-b08d-60f8f924ee89"),
                            Description = "Web with ASP.NET",
                            DurationWeeks = 16,
                            Price = 1350m,
                            Program = "1. Controllers and MVC 2. WebAPI 3.Angular",
                            Title = "ASP.NET",
                            TopicId = new Guid("92c6afa9-bfd1-41ba-996f-14c2af30811f")
                        },
                        new
                        {
                            Id = new Guid("43fd2f5c-c382-4339-abd6-bb612dcbaad7"),
                            Description = "Unity Game Development",
                            DurationWeeks = 16,
                            Price = 1850m,
                            Program = "1. What is Unity",
                            Title = "Unity",
                            TopicId = new Guid("92c6afa9-bfd1-41ba-996f-14c2af30811f")
                        });
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
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
                            Id = new Guid("c9dcdaf2-1310-425a-9055-f7d5381b8560"),
                            BirthDate = new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Vasilii_Petrov@gmail.com",
                            FirstName = "Vasilii",
                            Gender = 0,
                            LastName = "Petrov",
                            Phone = "+375(29)6581201",
                            StartDate = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("6cfb44dd-2002-4eb2-be10-0b0a019ffd9b")
                        },
                        new
                        {
                            Id = new Guid("d3d5fcf5-7b09-4e05-9441-68920b433505"),
                            BirthDate = new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Petr_Vasiliev@gmail.com",
                            FirstName = "Petr",
                            Gender = 0,
                            LastName = "Vasiliev",
                            Phone = "+375(33)8509872",
                            StartDate = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("6cfb44dd-2002-4eb2-be10-0b0a019ffd9b")
                        },
                        new
                        {
                            Id = new Guid("43688573-d46e-489f-9094-d1ec11bfd517"),
                            BirthDate = new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ivan_Bezfamilnyi@gmail.com",
                            FirstName = "Ivan",
                            Gender = 0,
                            LastName = "Bezfamilnyi",
                            Phone = "+375(33)4053649",
                            StartDate = new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("e5a7e9b4-6247-49cd-8598-3e18a27ad718")
                        },
                        new
                        {
                            Id = new Guid("74b25c68-326d-4ea1-8918-3af1012d0831"),
                            BirthDate = new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mariya_Sidorova@gmail.com",
                            FirstName = "Mariya",
                            Gender = 1,
                            LastName = "Sidorova",
                            Phone = "+375(25)4527264",
                            StartDate = new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("e5a7e9b4-6247-49cd-8598-3e18a27ad718")
                        },
                        new
                        {
                            Id = new Guid("bf804b38-fc44-4a87-a828-9d9f2fb2ba31"),
                            BirthDate = new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Vitali_Lukyanov@gmail.com",
                            FirstName = "Vitali",
                            Gender = 0,
                            LastName = "Lukyanov",
                            Phone = "+375(44)4874350",
                            StartDate = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("0fb829d4-bfd2-4c43-b3af-69570ac21c5c")
                        },
                        new
                        {
                            Id = new Guid("ac9460f8-e3a6-4866-880a-bd6d33bcdc39"),
                            BirthDate = new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Elvira_Zaytseva@gmail.com",
                            FirstName = "Elvira",
                            Gender = 0,
                            LastName = "Zaytseva",
                            Phone = "+375(25)5850614",
                            StartDate = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("0fb829d4-bfd2-4c43-b3af-69570ac21c5c")
                        },
                        new
                        {
                            Id = new Guid("128741ca-9334-4b7a-b8fa-1362bc8ed273"),
                            BirthDate = new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Alexander_Ptichkin@gmail.com",
                            FirstName = "Alexander",
                            Gender = 0,
                            LastName = "Ptichkin",
                            Phone = "+375(29)5335521",
                            StartDate = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentGroupId = new Guid("0fb829d4-bfd2-4c43-b3af-69570ac21c5c")
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
                            Id = new Guid("6cfb44dd-2002-4eb2-be10-0b0a019ffd9b"),
                            TeacherId = new Guid("16fa3563-3467-4dcd-8f59-49e3f6c6fd5b"),
                            Title = "ASP_21-1"
                        },
                        new
                        {
                            Id = new Guid("e5a7e9b4-6247-49cd-8598-3e18a27ad718"),
                            TeacherId = new Guid("61ca5df8-83a4-4705-b410-4f460b838731"),
                            Title = "ASP_21-2"
                        },
                        new
                        {
                            Id = new Guid("0fb829d4-bfd2-4c43-b3af-69570ac21c5c"),
                            TeacherId = new Guid("2be796f2-c306-4556-a4df-3884dfae501f"),
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

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkToProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("16fa3563-3467-4dcd-8f59-49e3f6c6fd5b"),
                            Bio = "Some information",
                            BirthDate = new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Petr_Reshetnikov@gmail.com",
                            FirstName = "Petr",
                            Gender = 0,
                            LastName = "Reshetnikov",
                            LinkToProfile = "https://www.linkedin.com/feed/",
                            Phone = "+375(44)6702702"
                        },
                        new
                        {
                            Id = new Guid("61ca5df8-83a4-4705-b410-4f460b838731"),
                            Bio = "Some other information",
                            BirthDate = new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mikhail_Andreev@gmail.com",
                            FirstName = "Mikhail",
                            Gender = 0,
                            LastName = "Andreev",
                            LinkToProfile = "https://www.linkedin.com/feed/",
                            Phone = "+375(29)8675329"
                        },
                        new
                        {
                            Id = new Guid("2be796f2-c306-4556-a4df-3884dfae501f"),
                            Bio = "Some other information",
                            BirthDate = new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Natalia_Usovich@gmail.com",
                            FirstName = "Natalia",
                            Gender = 1,
                            LastName = "Usovich",
                            LinkToProfile = "https://www.linkedin.com/feed/",
                            Phone = "+375(29)3963759"
                        });
                });

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ParentId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId1");

                    b.ToTable("Topic");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92c6afa9-bfd1-41ba-996f-14c2af30811f"),
                            Description = ".Net (ASP.NET, Unity)",
                            Title = ".Net"
                        },
                        new
                        {
                            Id = new Guid("60ec6aae-cd23-4d55-8f9e-0179f1c69d47"),
                            Description = "JS, HTML, CSS",
                            Title = "Frontend"
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

                    b.HasData(
                        new
                        {
                            Id = "d5a6a007-6ff2-4a9d-841f-0bb45c42ecca",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8dc67405-d0c5-45da-8bc7-ab61a0475c5d",
                            Email = "admin@ECCRM.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ECCRM.COM",
                            NormalizedUserName = "ADMIN@ECCRM.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOhIaWLVJXd1DlNwgOVAJH0HDcNNgBjBpjbRF/KvXIziRXypROkC8GvwrC3lVDxTMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "57f7e9f7-7fe7-4af8-9c89-d5042e00e5b1",
                            TwoFactorEnabled = false,
                            UserName = "admin@ECCRM.com"
                        },
                        new
                        {
                            Id = "0c1c67c1-0b06-43a2-94b8-2fd22411fd3b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "da5ad772-3438-4fde-9ab2-0e9bdb5c9395",
                            Email = "manager@ECCRM.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@ECCRM.COM",
                            NormalizedUserName = "MANAGER@ECCRM.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO1nya8shj6Crnfv2s1hukjdbA0Fj/Edn+f0RZHFJc7GcJE6Z0GgPOEzfmGd+bw8iA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "796ee398-dfba-4da4-9e11-82dec3ae06ec",
                            TwoFactorEnabled = false,
                            UserName = "manager@ECCRM.com"
                        });
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

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Course", b =>
                {
                    b.HasOne("EducationCenterCRM.BLL.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
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

            modelBuilder.Entity("EducationCenterCRM.BLL.Models.Topic", b =>
                {
                    b.HasOne("EducationCenterCRM.BLL.Models.Topic", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId1");

                    b.Navigation("Parent");
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
