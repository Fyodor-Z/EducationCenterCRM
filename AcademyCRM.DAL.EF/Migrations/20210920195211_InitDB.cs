using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyCRM.DAL.EF.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.Id);
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
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "FirstName", "Gender", "LastName", "LinkToProfile" },
                values: new object[] { new Guid("69c233e8-2438-487d-8183-20fbc3508e68"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "FirstName", "Gender", "LastName", "LinkToProfile" },
                values: new object[] { new Guid("51a5dee2-a947-4b73-96a4-2baa4c5ab0dd"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "FirstName", "Gender", "LastName", "LinkToProfile" },
                values: new object[] { new Guid("4bb55f0e-548a-45d0-8ffc-1811001090e1"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("e436725f-6c70-4832-8855-9fb7ed1085c8"), new Guid("69c233e8-2438-487d-8183-20fbc3508e68"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("b6aec2a4-2b4e-4234-8b70-2cac027e5047"), new Guid("51a5dee2-a947-4b73-96a4-2baa4c5ab0dd"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("4422e69a-3936-4385-9b61-7722a68c3000"), new Guid("4bb55f0e-548a-45d0-8ffc-1811001090e1"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "FirstName", "Gender", "LastName", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("9565550c-5828-4df4-bdd4-0e17d7653a93"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii", 0, "Petrov", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e436725f-6c70-4832-8855-9fb7ed1085c8") },
                    { new Guid("8acd2498-140f-4e30-9f58-9c91a4910650"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr", 0, "Vasiliev", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e436725f-6c70-4832-8855-9fb7ed1085c8") },
                    { new Guid("32a754ba-87ff-4f02-b740-e093e00be8b6"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", 0, "Bezfamilnyi", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6aec2a4-2b4e-4234-8b70-2cac027e5047") },
                    { new Guid("a32f674b-7fd7-4890-a452-56977d07d135"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya", 1, "Sidorova", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6aec2a4-2b4e-4234-8b70-2cac027e5047") },
                    { new Guid("67e403c0-ac99-4383-9f4b-99477765e16c"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali", 0, "Lukyanov", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4422e69a-3936-4385-9b61-7722a68c3000") },
                    { new Guid("7dc77f20-2bf5-41f2-952c-a38482d7a9b2"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira", 0, "Zaytseva", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4422e69a-3936-4385-9b61-7722a68c3000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroups_TeacherId",
                table: "StudentGroups",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentGroupId",
                table: "Students",
                column: "StudentGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentGroups");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
