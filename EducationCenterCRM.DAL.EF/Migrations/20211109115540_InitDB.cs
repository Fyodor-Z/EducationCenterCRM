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
                    { "7449f1f9-32b5-40cf-81d0-a26d5595783d", 0, "9860e44e-9186-4b06-8234-7e3d08d147e1", "admin@ECCRM.com", true, false, null, "ADMIN@ECCRM.COM", "ADMIN@ECCRM.COM", "AQAAAAEAACcQAAAAEDFAzl26kpuoUpMGi8XUwvYkGQqkMHOL1DOJJ4elManPP1nu4cwjWxm/0Uy9O86wzw==", null, false, "43a44b01-a3c6-4382-8c24-399e4b2cd905", false, "admin@ECCRM.com" },
                    { "dfecda69-283f-4aa3-b83e-39eb093c2eca", 0, "9b9b23a0-20d9-4dd7-984b-32416e5a832e", "manager@ECCRM.com", true, false, null, "MANAGER@ECCRM.COM", "MANAGER@ECCRM.COM", "AQAAAAEAACcQAAAAEHMykHKMeCSJRv5auO0zELBMRgJ9Emndl+UY8HPnfiJWj0El41txw7/vG/2ofpInSA==", null, false, "21bea852-1eee-4274-bee0-859c77814599", false, "manager@ECCRM.com" },
                    { "038e759e-98fe-495a-882b-b99250502e45", 0, "372527fb-7b00-4ee0-9771-ab68354ee315", "Petr_Reshetnikov@gmail.com", true, false, null, "PETR_RESHETNIKOV@GMAIL.COM", "PETR_RESHETNIKOV@GMAIL.COM", "AQAAAAEAACcQAAAAELrHs4ZJOvwffissgCVYRuW1zrD8tGqrzsVcZ5E+29x7AApGkiAaabn8JhLK/J1TKA==", null, false, "f9260080-b94d-4459-b8d0-de3c171110bb", false, "Petr_Reshetnikov@gmail.com" },
                    { "cb6daeb6-f0b1-4e0a-bd1d-5bdac1bc0c17", 0, "5e832a5d-d561-49f8-8152-f3c8e95fc1a7", "Mikhail_Andreev@gmail.com", true, false, null, "MIKHAIL_ANDREEV@GMAIL.COM", "MIKHAIL_ANDREEV@GMAIL.COM", "AQAAAAEAACcQAAAAEA+8u2361ZAlZ6avlENmvpIDELKrPmbX7rWs7karVLzqVpRV+HqYuSo2ew6FURXZFw==", null, false, "41e3c1a3-63f8-4739-b65d-d0cbcf73d926", false, "Mikhail_Andreev@gmail.com" },
                    { "cc4b4eac-6727-4c1c-ba35-39dc583d2dc0", 0, "8668fb62-7a8b-4904-81e9-2fa3f131ba30", "Natalia_Usovich@gmail.com", true, false, null, "NATALIA_USOVICH@GMAIL.COM", "NATALIA_USOVICH@GMAIL.COM", "AQAAAAEAACcQAAAAEJfHwWgeDr+BPKAJciDgladG2YBUWPErR898JkJ8gG33Do4UETzIFKDmL+ViFhSGjg==", null, false, "ddde09c5-8c90-47aa-9973-effb6f9ee4c3", false, "Natalia_Usovich@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[,]
                {
                    { new Guid("fa33d33a-988c-43d3-b52a-f3fc81a5c113"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Reshetnikov@gmail.com", "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", "+375(33)2301695" },
                    { new Guid("ffb1dc1e-6079-4612-aae8-19a4957500ba"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail_Andreev@gmail.com", "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", "+375(25)9557996" },
                    { new Guid("598d8780-c72e-4824-b5f1-72f48ac19a15"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia_Usovich@gmail.com", "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", "+375(25)7021899" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "ParentId", "ParentId1", "Title" },
                values: new object[,]
                {
                    { new Guid("f787ae41-b99f-4edd-a8d1-2c6d8b92a017"), ".Net (ASP.NET, Unity)", null, null, ".Net" },
                    { new Guid("1e74e8c5-f5cd-434e-9759-49516313940b"), "JS, HTML, CSS", null, null, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationWeeks", "Price", "Program", "Title", "TopicId" },
                values: new object[,]
                {
                    { new Guid("293e277c-a80c-4a2a-a914-2c20512c7e36"), "Introduction to C#", 12, 1250m, "1. Getting Started", "Introduction to C#", new Guid("f787ae41-b99f-4edd-a8d1-2c6d8b92a017") },
                    { new Guid("ba292f90-d522-4351-adc6-4462a0a59e03"), "Web with ASP.NET", 16, 1350m, "1. Controllers and MVC 2. WebAPI 3.Angular", "ASP.NET", new Guid("f787ae41-b99f-4edd-a8d1-2c6d8b92a017") },
                    { new Guid("45062d07-2863-4902-90ae-642c5f769132"), "Unity Game Development", 16, 1850m, "1. What is Unity", "Unity", new Guid("f787ae41-b99f-4edd-a8d1-2c6d8b92a017") },
                    { new Guid("cfa59c8f-6f74-4da4-a048-5beae3b4325c"), "Introduction to Java", 4, 1550m, "1. Getting Started", "Introduction to Web", new Guid("1e74e8c5-f5cd-434e-9759-49516313940b") }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("25d71009-5d5b-43cc-9865-36d97598e8c0"), new Guid("ba292f90-d522-4351-adc6-4462a0a59e03"), 0, new Guid("fa33d33a-988c-43d3-b52a-f3fc81a5c113"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("7f74facb-b927-4b9b-8c0d-4f3945bbb73a"), new Guid("ba292f90-d522-4351-adc6-4462a0a59e03"), 0, new Guid("ffb1dc1e-6079-4612-aae8-19a4957500ba"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("e33436dd-9172-47de-a61a-a583d9347ead"), new Guid("cfa59c8f-6f74-4da4-a048-5beae3b4325c"), 0, new Guid("598d8780-c72e-4824-b5f1-72f48ac19a15"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "GroupId", "LessonDate" },
                values: new object[,]
                {
                    { new Guid("b9d0f550-6112-49d4-a38d-31a5e09e7c8d"), new Guid("25d71009-5d5b-43cc-9865-36d97598e8c0"), new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("34af2139-a78e-4930-916d-7c85063123f9"), new Guid("25d71009-5d5b-43cc-9865-36d97598e8c0"), new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("59a3c781-79f5-4e77-baf3-57987763488d"), new Guid("25d71009-5d5b-43cc-9865-36d97598e8c0"), new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("b445b323-84bb-4f34-8484-49a4ff303665"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii_Petrov@gmail.com", "Vasilii", 0, "Petrov", "+375(25)4773941", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("25d71009-5d5b-43cc-9865-36d97598e8c0") },
                    { new Guid("e07043a9-b35f-460a-9324-f80c67867b60"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Vasiliev@gmail.com", "Petr", 0, "Vasiliev", "+375(25)5377414", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("25d71009-5d5b-43cc-9865-36d97598e8c0") },
                    { new Guid("8e2ac9c1-9b8d-4d8b-bb38-d6a806828f51"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Bezfamilnyi@gmail.com", "Ivan", 0, "Bezfamilnyi", "+375(44)6121978", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7f74facb-b927-4b9b-8c0d-4f3945bbb73a") },
                    { new Guid("8249a6ff-a322-46e5-a0de-de2fbc810eb2"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya_Sidorova@gmail.com", "Mariya", 1, "Sidorova", "+375(25)6650766", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7f74facb-b927-4b9b-8c0d-4f3945bbb73a") },
                    { new Guid("bd081eb2-7237-4479-830f-197ef4c210e0"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali_Lukyanov@gmail.com", "Vitali", 0, "Lukyanov", "+375(33)6888895", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e33436dd-9172-47de-a61a-a583d9347ead") },
                    { new Guid("157ff56f-4a2a-4fd2-8747-08502d6890d5"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira_Zaytseva@gmail.com", "Elvira", 0, "Zaytseva", "+375(25)7429121", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e33436dd-9172-47de-a61a-a583d9347ead") },
                    { new Guid("8a68bd7f-6f8b-4a14-bd0f-9c79cceeb3f8"), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander_Ptichkin@gmail.com", "Alexander", 0, "Ptichkin", "+375(44)3077104", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e33436dd-9172-47de-a61a-a583d9347ead") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "LessonId", "Score", "StudentId" },
                values: new object[,]
                {
                    { new Guid("97a55ecf-db5e-4d43-abc7-aca9a8d2186c"), new Guid("b9d0f550-6112-49d4-a38d-31a5e09e7c8d"), 8, new Guid("b445b323-84bb-4f34-8484-49a4ff303665") },
                    { new Guid("f068c6a0-11a3-45bc-b5bc-4d6f2d6890f7"), new Guid("34af2139-a78e-4930-916d-7c85063123f9"), 9, new Guid("b445b323-84bb-4f34-8484-49a4ff303665") },
                    { new Guid("8aed2be8-d7dc-4091-b079-b87f6042c529"), new Guid("b9d0f550-6112-49d4-a38d-31a5e09e7c8d"), 7, new Guid("e07043a9-b35f-460a-9324-f80c67867b60") },
                    { new Guid("8e3155f8-0237-4c7d-90d4-8fe6756304ff"), new Guid("34af2139-a78e-4930-916d-7c85063123f9"), 7, new Guid("e07043a9-b35f-460a-9324-f80c67867b60") },
                    { new Guid("cacaf4bb-c917-4e2a-ad5a-631e8f79915e"), new Guid("59a3c781-79f5-4e77-baf3-57987763488d"), 7, new Guid("e07043a9-b35f-460a-9324-f80c67867b60") }
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
