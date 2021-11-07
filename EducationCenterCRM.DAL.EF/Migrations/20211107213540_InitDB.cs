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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dcfb967f-20f0-4e53-9367-3c2a63af61a4", 0, "61b3008c-023e-4b7f-9346-cfecda392374", "admin@ECCRM.com", true, false, null, "ADMIN@ECCRM.COM", "ADMIN@ECCRM.COM", "AQAAAAEAACcQAAAAEFhWG/wjiHUolnm++6zZ7ZI5miSf9WCrsxJrcupIT7hTrJwApKrEpzysDlSa1UVQ2A==", null, false, "eaf06bd4-198f-490c-a0fc-94dc171277b8", false, "admin@ECCRM.com" },
                    { "5e2ffcc6-e42e-40db-a77c-44fa83c22825", 0, "97f1e431-eae7-42ce-8458-955de4c5c3ce", "manager@ECCRM.com", true, false, null, "MANAGER@ECCRM.COM", "MANAGER@ECCRM.COM", "AQAAAAEAACcQAAAAEPwJUAYigDptW8rAhTucT7zFoH0bFwInI8tgdCBnTSQDWWhwjU7bTlAuXVKlUbV1dg==", null, false, "d6240ad9-f8ea-4420-9b7b-b603208eb17f", false, "manager@ECCRM.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[,]
                {
                    { new Guid("7941ba4e-2726-4ef9-a47d-fe11175298bf"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Reshetnikov@gmail.com", "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", "+375(25)3927600" },
                    { new Guid("2bdec0ad-12bd-4833-bc88-1c3d110f6cdf"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail_Andreev@gmail.com", "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", "+375(44)2794440" },
                    { new Guid("4983ccd4-3cdb-4285-9d29-8532afe4a3d5"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia_Usovich@gmail.com", "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", "+375(33)6654976" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "ParentId", "ParentId1", "Title" },
                values: new object[,]
                {
                    { new Guid("11a8e567-a308-4553-9f4c-ffa77a1dccf2"), ".Net (ASP.NET, Unity)", null, null, ".Net" },
                    { new Guid("8fb9864b-f51d-4218-9884-25d792a8a898"), "JS, HTML, CSS", null, null, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationWeeks", "Price", "Program", "Title", "TopicId" },
                values: new object[,]
                {
                    { new Guid("3bb64004-434d-4c7e-9c38-b747f49b5907"), "Introduction to C#", 12, 1250m, "1. Getting Started", "Introduction to C#", new Guid("11a8e567-a308-4553-9f4c-ffa77a1dccf2") },
                    { new Guid("184ff06a-7656-47a8-95ce-64a33f6e59d1"), "Web with ASP.NET", 16, 1350m, "1. Controllers and MVC 2. WebAPI 3.Angular", "ASP.NET", new Guid("11a8e567-a308-4553-9f4c-ffa77a1dccf2") },
                    { new Guid("b8a323e7-8002-4a81-a4ad-6321ff3b6c8c"), "Unity Game Development", 16, 1850m, "1. What is Unity", "Unity", new Guid("11a8e567-a308-4553-9f4c-ffa77a1dccf2") },
                    { new Guid("3a5ea877-217d-4f74-892a-5cc669fe4b05"), "Introduction to Java", 4, 1550m, "1. Getting Started", "Introduction to Web", new Guid("8fb9864b-f51d-4218-9884-25d792a8a898") }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4"), new Guid("184ff06a-7656-47a8-95ce-64a33f6e59d1"), 0, new Guid("7941ba4e-2726-4ef9-a47d-fe11175298bf"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("feee4be9-0eb1-49e4-aab2-35bf3aafa6fb"), new Guid("184ff06a-7656-47a8-95ce-64a33f6e59d1"), 0, new Guid("2bdec0ad-12bd-4833-bc88-1c3d110f6cdf"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("ad78301b-639e-423b-b5ff-3ae107662278"), new Guid("3a5ea877-217d-4f74-892a-5cc669fe4b05"), 0, new Guid("4983ccd4-3cdb-4285-9d29-8532afe4a3d5"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "GroupId", "LessonDate" },
                values: new object[,]
                {
                    { new Guid("bc1764d5-4803-4302-bdcc-845d1206ed73"), new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4"), new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9f03d7b6-ec13-4f65-9bea-af4ece24d7b3"), new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4"), new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6fe85cd5-0f64-4a6d-97fe-992ddcbc140e"), new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4"), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("e817d036-86a2-406e-ac21-34f188ab888d"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii_Petrov@gmail.com", "Vasilii", 0, "Petrov", "+375(29)9522838", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4") },
                    { new Guid("f86fcbe5-ea94-4b6d-a83a-bfd2b3669453"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Vasiliev@gmail.com", "Petr", 0, "Vasiliev", "+375(44)9996424", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4") },
                    { new Guid("51e3b74d-33af-4359-82c6-569d2accfe4f"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Bezfamilnyi@gmail.com", "Ivan", 0, "Bezfamilnyi", "+375(29)4643947", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("feee4be9-0eb1-49e4-aab2-35bf3aafa6fb") },
                    { new Guid("d4596823-8a46-4608-96af-3efab3bc0dbb"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya_Sidorova@gmail.com", "Mariya", 1, "Sidorova", "+375(29)8978666", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("feee4be9-0eb1-49e4-aab2-35bf3aafa6fb") },
                    { new Guid("8e275e5c-243c-4fb3-a480-214594dbcf57"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali_Lukyanov@gmail.com", "Vitali", 0, "Lukyanov", "+375(33)9166154", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad78301b-639e-423b-b5ff-3ae107662278") },
                    { new Guid("0f868c0a-fc84-4dda-bacd-40316aadb904"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira_Zaytseva@gmail.com", "Elvira", 0, "Zaytseva", "+375(33)3946461", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad78301b-639e-423b-b5ff-3ae107662278") },
                    { new Guid("f49cc417-500d-4f51-9d35-fa7863e2951c"), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander_Ptichkin@gmail.com", "Alexander", 0, "Ptichkin", "+375(44)6742521", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad78301b-639e-423b-b5ff-3ae107662278") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "LessonId", "Score", "StudentId" },
                values: new object[,]
                {
                    { new Guid("4f2e9b1f-1ff9-43e1-be4c-8c50cfa2c8b9"), new Guid("bc1764d5-4803-4302-bdcc-845d1206ed73"), 8, new Guid("e817d036-86a2-406e-ac21-34f188ab888d") },
                    { new Guid("52ebfc6b-8080-49f8-b1d1-ded77eeae55e"), new Guid("9f03d7b6-ec13-4f65-9bea-af4ece24d7b3"), 9, new Guid("e817d036-86a2-406e-ac21-34f188ab888d") },
                    { new Guid("0b0b40e9-b6a3-44c9-a004-de9f4ffaae1b"), new Guid("bc1764d5-4803-4302-bdcc-845d1206ed73"), 7, new Guid("f86fcbe5-ea94-4b6d-a83a-bfd2b3669453") },
                    { new Guid("9f0dcc20-b848-44b1-b207-ad50f91480d8"), new Guid("9f03d7b6-ec13-4f65-9bea-af4ece24d7b3"), 7, new Guid("f86fcbe5-ea94-4b6d-a83a-bfd2b3669453") },
                    { new Guid("ea2ea6aa-066c-4195-95e9-890aff580290"), new Guid("6fe85cd5-0f64-4a6d-97fe-992ddcbc140e"), 7, new Guid("f86fcbe5-ea94-4b6d-a83a-bfd2b3669453") }
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
