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
                    { "e3102172-85e8-448a-ae92-a5d770e54383", 0, "b3bb0b38-b45e-4ebc-95b6-8343b16fdc58", "admin@ECCRM.com", true, false, null, "ADMIN@ECCRM.COM", "ADMIN@ECCRM.COM", "AQAAAAEAACcQAAAAEHDCT+eQ0NQv25m0y+3etwMkeMXIDV4AXB7yrYpKiOfK+Ds0cxesV3jOUJijD513mw==", null, false, "03978beb-cc6b-4680-a7ea-1bac2b03626b", false, "admin@ECCRM.com" },
                    { "4cae4499-ebc6-49f9-89a7-a31b4feb8d90", 0, "553b9391-c40b-4ac0-b65d-dc5c5221b3f6", "manager@ECCRM.com", true, false, null, "MANAGER@ECCRM.COM", "MANAGER@ECCRM.COM", "AQAAAAEAACcQAAAAEIzYQCvUz5zbDxkpgVsPQ/N1tV3Xv4eiUWVpAyjlIv7rCWQ/hSugnL0xKcOgkidu6w==", null, false, "448a6f59-0d38-4e5b-861b-9b853c46ce25", false, "manager@ECCRM.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[,]
                {
                    { new Guid("7985804b-98e1-4731-ae78-4b4d4d1967e8"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Reshetnikov@gmail.com", "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", "+375(29)8744226" },
                    { new Guid("4a91636d-cef0-4090-9a87-e921cbfe9372"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail_Andreev@gmail.com", "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", "+375(33)9866154" },
                    { new Guid("90cd0681-8441-48c0-aecd-3f662d19cdb6"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia_Usovich@gmail.com", "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", "+375(33)2766601" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "ParentId", "ParentId1", "Title" },
                values: new object[,]
                {
                    { new Guid("63c05a95-2406-4ff2-ac47-da0d5e626974"), ".Net (ASP.NET, Unity)", null, null, ".Net" },
                    { new Guid("bf39c845-451a-4dfd-b0e8-fe2600979783"), "JS, HTML, CSS", null, null, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationWeeks", "Price", "Program", "Title", "TopicId" },
                values: new object[,]
                {
                    { new Guid("6afe1900-400f-4f31-aaef-8be81dec93ec"), "Introduction to C#", 12, 1250m, "1. Getting Started", "Introduction to C#", new Guid("63c05a95-2406-4ff2-ac47-da0d5e626974") },
                    { new Guid("0b8a1f78-0f1d-4de8-a296-a5621c0df940"), "Web with ASP.NET", 16, 1350m, "1. Controllers and MVC 2. WebAPI 3.Angular", "ASP.NET", new Guid("63c05a95-2406-4ff2-ac47-da0d5e626974") },
                    { new Guid("5fc01797-3ba0-4eb0-ac6c-2e3e8b2a8603"), "Unity Game Development", 16, 1850m, "1. What is Unity", "Unity", new Guid("63c05a95-2406-4ff2-ac47-da0d5e626974") },
                    { new Guid("5f08621d-c9db-41de-a342-d542fdac3c25"), "Introduction to Java", 4, 1550m, "1. Getting Started", "Introduction to Web", new Guid("bf39c845-451a-4dfd-b0e8-fe2600979783") }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("e1e7f21d-07df-4122-8ba2-7259530014a1"), new Guid("0b8a1f78-0f1d-4de8-a296-a5621c0df940"), 0, new Guid("7985804b-98e1-4731-ae78-4b4d4d1967e8"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("e3726445-a4e7-4e4e-a11d-3ef70f3a88a6"), new Guid("0b8a1f78-0f1d-4de8-a296-a5621c0df940"), 0, new Guid("4a91636d-cef0-4090-9a87-e921cbfe9372"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("7c71bb98-abe0-42e1-a36d-de0c9207ceb3"), new Guid("5f08621d-c9db-41de-a342-d542fdac3c25"), 0, new Guid("90cd0681-8441-48c0-aecd-3f662d19cdb6"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("6361ee62-9814-462f-a564-6bb85cb7ed39"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii_Petrov@gmail.com", "Vasilii", 0, "Petrov", "+375(44)3827882", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1e7f21d-07df-4122-8ba2-7259530014a1") },
                    { new Guid("6bb4af6d-07a6-4c18-ab00-a6eace2a5710"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Vasiliev@gmail.com", "Petr", 0, "Vasiliev", "+375(44)7255171", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e1e7f21d-07df-4122-8ba2-7259530014a1") },
                    { new Guid("0d9f5cc1-ad5a-42a4-a8be-abf10f66ad33"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Bezfamilnyi@gmail.com", "Ivan", 0, "Bezfamilnyi", "+375(25)6131742", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3726445-a4e7-4e4e-a11d-3ef70f3a88a6") },
                    { new Guid("1259dc9d-a646-48bd-a574-85862825dd5d"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya_Sidorova@gmail.com", "Mariya", 1, "Sidorova", "+375(33)9889303", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3726445-a4e7-4e4e-a11d-3ef70f3a88a6") },
                    { new Guid("7a808135-f36c-4b18-926c-be7a2d80f395"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali_Lukyanov@gmail.com", "Vitali", 0, "Lukyanov", "+375(33)9404154", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7c71bb98-abe0-42e1-a36d-de0c9207ceb3") },
                    { new Guid("6e7dd2f5-e7ad-4a46-8c67-2c9bbaff0dae"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira_Zaytseva@gmail.com", "Elvira", 0, "Zaytseva", "+375(33)9043868", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7c71bb98-abe0-42e1-a36d-de0c9207ceb3") },
                    { new Guid("7ee607ee-0f30-42b8-ba6a-46528047998e"), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander_Ptichkin@gmail.com", "Alexander", 0, "Ptichkin", "+375(25)4461701", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7c71bb98-abe0-42e1-a36d-de0c9207ceb3") }
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
                name: "StudentRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
