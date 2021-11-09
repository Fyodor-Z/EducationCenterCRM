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
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "StudentRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        onDelete: ReferentialAction.SetNull);
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1de47a43-055c-49d1-89de-f302008be610", 0, "1d74cc49-0dd8-4462-849a-3ac014c726d2", "admin@ECCRM.com", true, false, null, "ADMIN@ECCRM.COM", "ADMIN@ECCRM.COM", "AQAAAAEAACcQAAAAEGLZ9A5ayRoo0XAGzO1SdUVcIyVx8bS5I5t0NjRuGodwIyWlY4F3K1woIyL5xXsxlQ==", null, false, "a9436fac-33d1-4c2e-b5dd-d7fa9e9d9525", false, "admin@ECCRM.com" },
                    { "0b733177-1a2e-4cbe-b4c9-bd652ff5824c", 0, "915b842e-b02f-4302-ab0f-e163bf08700a", "manager@ECCRM.com", true, false, null, "MANAGER@ECCRM.COM", "MANAGER@ECCRM.COM", "AQAAAAEAACcQAAAAEMS5Ikbu3ftrXaaNGIyZfE+YeqpTV/aBsutqv+4KY1x0gBL+XyCXc+sVPaYPzhxYFA==", null, false, "867b1e0d-760f-4b48-adb5-4a6edc724fea", false, "manager@ECCRM.com" },
                    { "b2331cbd-9caa-46b8-99b0-93e3c6546f48", 0, "5d0c271f-b159-4595-af26-cb6b47b0ef63", "Petr_Reshetnikov@gmail.com", true, false, null, "PETR_RESHETNIKOV@GMAIL.COM", "PETR_RESHETNIKOV@GMAIL.COM", "AQAAAAEAACcQAAAAEB7mP+PIycj0orHCWBFsO27OQ9TmNSZ9/ewlN4/LJfIn9goiuwp40IX4tLo1fmVRpA==", null, false, "806f6ac2-a7d8-4847-88fa-eee5d76cb3c8", false, "Petr_Reshetnikov@gmail.com" },
                    { "4ae2d1a7-f4d5-4935-a44e-04a3a9625c46", 0, "b8cdfc56-803d-43aa-a015-456770ec568e", "Mikhail_Andreev@gmail.com", true, false, null, "MIKHAIL_ANDREEV@GMAIL.COM", "MIKHAIL_ANDREEV@GMAIL.COM", "AQAAAAEAACcQAAAAEOynCc6+0E0ODHohwkWe2El9VP68+ElA0LTL3J8Bt4zkUNiycRpG8plXiGCjQanFzg==", null, false, "bd376cb2-bef2-43f7-9dfd-3060045c4539", false, "Mikhail_Andreev@gmail.com" },
                    { "95057a4c-ba0f-4e5a-89fb-4495ff026d56", 0, "5976b9aa-45ce-4c42-85fb-aebf4ff31cde", "Natalia_Usovich@gmail.com", true, false, null, "NATALIA_USOVICH@GMAIL.COM", "NATALIA_USOVICH@GMAIL.COM", "AQAAAAEAACcQAAAAENAQ4hscPMDjMT7+XG4QrX3DoekDHIrKqdcxye4yeW6oICOvWTGiGjs5stUMADYVFQ==", null, false, "f6a286ab-a2f5-4438-9a31-e491258eec9c", false, "Natalia_Usovich@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[,]
                {
                    { new Guid("fa4c1873-7e58-4f1c-a37c-acc36a6b9773"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Reshetnikov@gmail.com", "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", "+375(25)4788854" },
                    { new Guid("8a13e31b-c9a1-4c45-b9ef-4518e956bee9"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail_Andreev@gmail.com", "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", "+375(44)9181215" },
                    { new Guid("3024d86b-a6b4-4b0b-aac7-803e4a13354f"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia_Usovich@gmail.com", "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", "+375(25)3685395" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "ParentId", "ParentId1", "Title" },
                values: new object[,]
                {
                    { new Guid("93a67efc-57d9-4b03-afe4-90bc565855d7"), ".Net (ASP.NET, Unity)", null, null, ".Net" },
                    { new Guid("3c38486f-d0ad-49e0-b05a-76009bf34887"), "JS, HTML, CSS", null, null, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationWeeks", "Price", "Program", "Title", "TopicId" },
                values: new object[,]
                {
                    { new Guid("98afda61-3a49-455b-bc79-fe35e2ebaeb4"), "Introduction to C#", 12, 1250m, "1. Getting Started", "Introduction to C#", new Guid("93a67efc-57d9-4b03-afe4-90bc565855d7") },
                    { new Guid("e6431dc5-a244-4448-8acb-a2a250e11261"), "Web with ASP.NET", 16, 1350m, "1. Controllers and MVC 2. WebAPI 3.Angular", "ASP.NET", new Guid("93a67efc-57d9-4b03-afe4-90bc565855d7") },
                    { new Guid("b39bcabe-0fe3-44c7-a155-f8bc21b2529e"), "Unity Game Development", 16, 1850m, "1. What is Unity", "Unity", new Guid("93a67efc-57d9-4b03-afe4-90bc565855d7") },
                    { new Guid("c70c78fc-920b-477e-a9fa-2f4e345fc608"), "Introduction to Java", 4, 1550m, "1. Getting Started", "Introduction to Web", new Guid("3c38486f-d0ad-49e0-b05a-76009bf34887") }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new Guid("e6431dc5-a244-4448-8acb-a2a250e11261"), 0, new Guid("fa4c1873-7e58-4f1c-a37c-acc36a6b9773"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("379b6f52-6e23-48ed-9e32-537bd6111a46"), new Guid("e6431dc5-a244-4448-8acb-a2a250e11261"), 0, new Guid("8a13e31b-c9a1-4c45-b9ef-4518e956bee9"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("4683265e-ab69-4fa3-848a-46c12bd42815"), new Guid("c70c78fc-920b-477e-a9fa-2f4e345fc608"), 0, new Guid("3024d86b-a6b4-4b0b-aac7-803e4a13354f"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "GroupId", "LessonDate" },
                values: new object[,]
                {
                    { new Guid("30837595-d4a1-479e-bd15-1a88b157b5ce"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("74efe79a-24b7-449a-82ea-6b8b618e9266"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4ef6e1df-0383-4f4b-b512-5597a27e0a69"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("999c08ce-1655-43bf-aeb0-10808116d8a5"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3759d52d-d0b3-4cf1-8c25-1259ef3df347"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("60bcf8ab-798e-428d-b334-d54d3d272732"), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304"), new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii_Petrov@gmail.com", "Vasilii", 0, "Petrov", "+375(29)7126923", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304") },
                    { new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Vasiliev@gmail.com", "Petr", 0, "Vasiliev", "+375(29)3058717", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304") },
                    { new Guid("568853e7-776b-4085-822e-63c81e23a7b8"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anton_Yermolaichik@gmail.com", "Anton", 0, "Yermolaichik", "+375(25)4381032", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304") },
                    { new Guid("1bc81871-5e3c-4a3d-aa14-ade661501192"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexnader_Filipovets@gmail.com", "Alexnader", 0, "Filipovets", "+375(33)1547098", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ce9b298-caca-4a0c-b469-74e0b22e7304") },
                    { new Guid("e995407a-f3ba-4afa-b63a-d1569f1fb60a"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Bezfamilnyi@gmail.com", "Ivan", 0, "Bezfamilnyi", "+375(44)8364181", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("379b6f52-6e23-48ed-9e32-537bd6111a46") },
                    { new Guid("6b1c62ed-6a12-4785-a661-c50a12264cad"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya_Sidorova@gmail.com", "Mariya", 1, "Sidorova", "+375(33)8536822", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("379b6f52-6e23-48ed-9e32-537bd6111a46") },
                    { new Guid("09a5b5df-4b1f-4c25-bcc5-c23fcdb9b7ad"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali_Lukyanov@gmail.com", "Vitali", 0, "Lukyanov", "+375(33)7813468", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4683265e-ab69-4fa3-848a-46c12bd42815") },
                    { new Guid("c3a4277b-9e38-4589-8813-5b66b0f42a45"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira_Zaytseva@gmail.com", "Elvira", 0, "Zaytseva", "+375(33)6121372", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4683265e-ab69-4fa3-848a-46c12bd42815") },
                    { new Guid("f7fd1bed-770e-4713-bff2-fd5b1b1bf18d"), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander_Ptichkin@gmail.com", "Alexander", 0, "Ptichkin", "+375(29)7532946", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4683265e-ab69-4fa3-848a-46c12bd42815") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "LessonId", "Score", "StudentId" },
                values: new object[,]
                {
                    { new Guid("8069bfdb-0307-4e6e-99ac-d5aa8a40703d"), new Guid("30837595-d4a1-479e-bd15-1a88b157b5ce"), 8, new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e") },
                    { new Guid("d488928b-d149-4584-a376-c3dd9e619f4a"), new Guid("3759d52d-d0b3-4cf1-8c25-1259ef3df347"), 7, new Guid("1bc81871-5e3c-4a3d-aa14-ade661501192") },
                    { new Guid("0758f9da-c83e-4301-97c1-8845ab99cd53"), new Guid("999c08ce-1655-43bf-aeb0-10808116d8a5"), 8, new Guid("1bc81871-5e3c-4a3d-aa14-ade661501192") },
                    { new Guid("1f62358e-0ada-486e-ac36-b39250882b5a"), new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), 8, new Guid("568853e7-776b-4085-822e-63c81e23a7b8") },
                    { new Guid("15375d24-a8bd-43b7-b703-74f44af5afa6"), new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), 8, new Guid("568853e7-776b-4085-822e-63c81e23a7b8") },
                    { new Guid("d0dd610e-6768-4229-9fb3-4d2fbba62d1b"), new Guid("3759d52d-d0b3-4cf1-8c25-1259ef3df347"), 8, new Guid("568853e7-776b-4085-822e-63c81e23a7b8") },
                    { new Guid("38b06494-dcdd-4a87-b405-aaf8ddba40a9"), new Guid("999c08ce-1655-43bf-aeb0-10808116d8a5"), 7, new Guid("568853e7-776b-4085-822e-63c81e23a7b8") },
                    { new Guid("6021e139-8369-4369-a247-4fae61a47bc7"), new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), 8, new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9") },
                    { new Guid("ddfdf862-fc84-4855-9c62-c5b8e8c59a94"), new Guid("3759d52d-d0b3-4cf1-8c25-1259ef3df347"), 9, new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9") },
                    { new Guid("70350fc4-00d6-46d0-ab85-54f5494fa072"), new Guid("999c08ce-1655-43bf-aeb0-10808116d8a5"), 9, new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9") },
                    { new Guid("32ac8deb-220d-4627-b011-76402b6c41d1"), new Guid("4ef6e1df-0383-4f4b-b512-5597a27e0a69"), 7, new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9") },
                    { new Guid("a19a3ba6-5365-4527-8dae-e727c5e7ccd1"), new Guid("74efe79a-24b7-449a-82ea-6b8b618e9266"), 7, new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9") },
                    { new Guid("c52dff00-332d-4ecb-9d59-2f634e048122"), new Guid("30837595-d4a1-479e-bd15-1a88b157b5ce"), 7, new Guid("1eb80e92-43bd-4d6f-9cf9-348f35edf2f9") },
                    { new Guid("a1ce7ab3-efa4-4379-99d6-0398243a26fa"), new Guid("60bcf8ab-798e-428d-b334-d54d3d272732"), 8, new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e") },
                    { new Guid("5ce7e820-4fb7-4aca-832e-151dea2a2c06"), new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), 8, new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e") },
                    { new Guid("deb58c6e-5c40-46bc-b424-7fb5947ee5b1"), new Guid("3759d52d-d0b3-4cf1-8c25-1259ef3df347"), 8, new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e") },
                    { new Guid("75f12393-021c-409d-969b-6257d51156db"), new Guid("999c08ce-1655-43bf-aeb0-10808116d8a5"), 7, new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e") },
                    { new Guid("493c712c-92f1-470e-a1d8-191416d82e7d"), new Guid("74efe79a-24b7-449a-82ea-6b8b618e9266"), 9, new Guid("6b082e66-423e-40a0-b8a2-0d85090c7d5e") },
                    { new Guid("651cc5a9-b1e2-4da5-8e1a-287251417d08"), new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), 6, new Guid("1bc81871-5e3c-4a3d-aa14-ade661501192") },
                    { new Guid("59d111fa-1399-4a57-9477-39023cb25443"), new Guid("c2ab0849-f535-4ffe-b748-f3773f030da3"), 6, new Guid("1bc81871-5e3c-4a3d-aa14-ade661501192") }
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
