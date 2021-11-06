using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationCenterCRM.DAL.EF.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkToProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Topics_ParentId1",
                        column: x => x.ParentId1,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DurationWeeks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGroups_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentGroups_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_StudentGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentRequests_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentRequests_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ef7aafae-ee72-4514-8143-e1c8ce3dead8", 0, "c6d9946e-4bf4-4968-aa34-36b246c265ed", "admin@ECCRM.com", true, false, null, "ADMIN@ECCRM.COM", "ADMIN@ECCRM.COM", "AQAAAAEAACcQAAAAECGgoAf+8RbWRjJN9CMyWLSrPgmLUxAhS11tDqba2U61sLVJehOA4Hqi+w1/Fm8XNw==", null, false, "cd3b2e1e-d6ee-4ad1-9286-4ed98da8beb9", false, "admin@ECCRM.com" },
                    { "28b136d8-0615-482c-a1ac-9a06a17fbbdf", 0, "afbe9c12-e92e-43bd-b687-22740f9fcfd0", "manager@ECCRM.com", true, false, null, "MANAGER@ECCRM.COM", "MANAGER@ECCRM.COM", "AQAAAAEAACcQAAAAEJNbO7YUeX3vR1HS+jEqM82VFEBHivqZDsupkvByJWgl87MW+b8mT8xxRX2Zlq9abQ==", null, false, "661db9ec-3c68-4530-9985-75fb82a6f600", false, "manager@ECCRM.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[,]
                {
                    { new Guid("e55425ac-e2c0-440c-ba43-567cd2340ed5"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Reshetnikov@gmail.com", "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", "+375(33)8512571" },
                    { new Guid("17e34f8c-024a-4c5b-bbb6-d5ef2b04c696"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail_Andreev@gmail.com", "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", "+375(33)8299742" },
                    { new Guid("1b9b85e5-275f-46a1-8c6f-f755f2322caa"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia_Usovich@gmail.com", "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", "+375(29)8417616" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "ParentId", "ParentId1", "Title" },
                values: new object[,]
                {
                    { new Guid("0420c370-19f7-4013-965a-202ad91aa2d8"), ".Net (ASP.NET, Unity)", null, null, ".Net" },
                    { new Guid("54a2f070-db56-45f0-9600-4d039c4e461d"), "JS, HTML, CSS", null, null, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationWeeks", "Price", "Program", "Title", "TopicId" },
                values: new object[,]
                {
                    { new Guid("edeed8db-9e07-4073-8f28-535f06a8a991"), "Introduction to C#", 12, 1250m, "1. Getting Started", "Introduction to C#", new Guid("0420c370-19f7-4013-965a-202ad91aa2d8") },
                    { new Guid("522f8eff-fd41-4124-936f-04ed21bd600e"), "Web with ASP.NET", 16, 1350m, "1. Controllers and MVC 2. WebAPI 3.Angular", "ASP.NET", new Guid("0420c370-19f7-4013-965a-202ad91aa2d8") },
                    { new Guid("0ba60e24-bdfd-4e07-ac33-c9e0def874e5"), "Unity Game Development", 16, 1850m, "1. What is Unity", "Unity", new Guid("0420c370-19f7-4013-965a-202ad91aa2d8") },
                    { new Guid("33cbdef2-704c-470e-b961-6503e1d49639"), "Introduction to Java", 4, 1550m, "1. Getting Started", "Introduction to Web", new Guid("54a2f070-db56-45f0-9600-4d039c4e461d") }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("2c76e78d-31a3-45b4-8f1c-fe8308adda29"), new Guid("522f8eff-fd41-4124-936f-04ed21bd600e"), 0, new Guid("e55425ac-e2c0-440c-ba43-567cd2340ed5"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("f6e41f60-8755-4175-b5aa-ae1aacbf4f83"), new Guid("522f8eff-fd41-4124-936f-04ed21bd600e"), 0, new Guid("17e34f8c-024a-4c5b-bbb6-d5ef2b04c696"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("a2101311-5f80-4101-9f46-3735b2b365c7"), new Guid("33cbdef2-704c-470e-b961-6503e1d49639"), 0, new Guid("1b9b85e5-275f-46a1-8c6f-f755f2322caa"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "GroupId", "LessonDate" },
                values: new object[,]
                {
                    { new Guid("de45abba-22ab-4d25-b281-d179db825a5b"), new Guid("2c76e78d-31a3-45b4-8f1c-fe8308adda29"), new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("25a59f39-7532-41a9-9b3f-d28633488045"), new Guid("2c76e78d-31a3-45b4-8f1c-fe8308adda29"), new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("490e64c3-0238-4ab3-a4a4-e55cec6ada22"), new Guid("2c76e78d-31a3-45b4-8f1c-fe8308adda29"), new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("5e5ec505-e319-42ac-97de-0178f72d690c"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii_Petrov@gmail.com", "Vasilii", 0, "Petrov", "+375(25)3440688", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c76e78d-31a3-45b4-8f1c-fe8308adda29") },
                    { new Guid("86722941-6f3c-4d9e-91af-28b5428e8072"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Vasiliev@gmail.com", "Petr", 0, "Vasiliev", "+375(25)6623549", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c76e78d-31a3-45b4-8f1c-fe8308adda29") },
                    { new Guid("ec5efb87-e8ac-4166-98dc-8511d9f4b828"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Bezfamilnyi@gmail.com", "Ivan", 0, "Bezfamilnyi", "+375(44)1752527", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6e41f60-8755-4175-b5aa-ae1aacbf4f83") },
                    { new Guid("94359ac8-dfc0-4565-af10-29bdb844b411"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya_Sidorova@gmail.com", "Mariya", 1, "Sidorova", "+375(29)1117432", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6e41f60-8755-4175-b5aa-ae1aacbf4f83") },
                    { new Guid("b7b1cfb6-56ca-4f1c-93b0-9de2164eab6e"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali_Lukyanov@gmail.com", "Vitali", 0, "Lukyanov", "+375(44)8837685", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2101311-5f80-4101-9f46-3735b2b365c7") },
                    { new Guid("edfc1535-df12-4e21-a5b5-13c1f4b5a513"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira_Zaytseva@gmail.com", "Elvira", 0, "Zaytseva", "+375(44)2760298", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2101311-5f80-4101-9f46-3735b2b365c7") },
                    { new Guid("a8a679ac-3119-4ae2-9880-08fc41415795"), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander_Ptichkin@gmail.com", "Alexander", 0, "Ptichkin", "+375(29)8881408", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2101311-5f80-4101-9f46-3735b2b365c7") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "LessonId", "Score", "StudentId" },
                values: new object[,]
                {
                    { new Guid("06b6caff-7977-449e-baad-5f7e14478bff"), new Guid("de45abba-22ab-4d25-b281-d179db825a5b"), 8, new Guid("5e5ec505-e319-42ac-97de-0178f72d690c") },
                    { new Guid("a4008a04-29dc-4f60-b826-0b4fc5f3c1e0"), new Guid("25a59f39-7532-41a9-9b3f-d28633488045"), 9, new Guid("5e5ec505-e319-42ac-97de-0178f72d690c") },
                    { new Guid("cfaf6d8f-2598-4f9b-b000-40e7d214be5a"), new Guid("de45abba-22ab-4d25-b281-d179db825a5b"), 7, new Guid("86722941-6f3c-4d9e-91af-28b5428e8072") },
                    { new Guid("b2caecf4-5465-4998-996e-822e03b2909d"), new Guid("25a59f39-7532-41a9-9b3f-d28633488045"), 7, new Guid("86722941-6f3c-4d9e-91af-28b5428e8072") },
                    { new Guid("f1a8b437-0939-4d61-a308-9b824942999e"), new Guid("490e64c3-0238-4ab3-a4a4-e55cec6ada22"), 7, new Guid("86722941-6f3c-4d9e-91af-28b5428e8072") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupId",
                table: "Lessons",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_LessonId",
                table: "Marks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_StudentId",
                table: "Marks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroups_CourseId",
                table: "StudentGroups",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroups_TeacherId",
                table: "StudentGroups",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRequests_CourseId",
                table: "StudentRequests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRequests_StudentId1",
                table: "StudentRequests",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentGroupId",
                table: "Students",
                column: "StudentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ParentId1",
                table: "Topics",
                column: "ParentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "StudentRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentGroups");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
