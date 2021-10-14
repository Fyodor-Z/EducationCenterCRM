using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationCenterCRM.DAL.EF.Migrations
{
    public partial class addEmailaddPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0f1d6a47-5778-462d-a242-a7bd347ea65e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("24223ec9-8eff-4f19-bbea-62c00510cae0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2e793b75-0867-425c-a9d5-80e78f5150b9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("36300be9-9f8c-4dd7-a7d0-c35700829ac9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cb96f6c2-ac27-40e9-8e8a-ac3eda194e4b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e733ec95-12aa-4c1e-8308-f61fcffa3a1b"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("30bfad55-973f-404f-b5e5-80d5b06f2079"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("91c79154-a504-4e24-a69f-bff96088b090"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cdc235b1-d4f1-4d71-a48b-28f4fe8d0d77"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[] { new Guid("b5d5b2f6-acff-4caf-b614-885b939a12a3"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", null });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[] { new Guid("597d92d7-b422-4d58-aec4-ab756604e212"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", null });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[] { new Guid("ed83d408-c681-42c7-bb5e-94e111f9b454"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", null });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("38bef0e0-b9ce-48fe-b0a2-2f799da80788"), new Guid("b5d5b2f6-acff-4caf-b614-885b939a12a3"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("20d1907f-a723-4d25-b6f8-3c22f85c6e11"), new Guid("597d92d7-b422-4d58-aec4-ab756604e212"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("28ac8641-64d2-4e1a-ba39-75c5d78f83ba"), new Guid("ed83d408-c681-42c7-bb5e-94e111f9b454"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("1db9a73b-ad35-4d1c-adc4-a230cf34cbfc"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vasilii", 0, "Petrov", null, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38bef0e0-b9ce-48fe-b0a2-2f799da80788") },
                    { new Guid("eb02287d-3f77-4e20-8fa2-fcc011e83b40"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Petr", 0, "Vasiliev", null, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38bef0e0-b9ce-48fe-b0a2-2f799da80788") },
                    { new Guid("e05a0e3c-0e78-4b3a-9f54-30c41feb606f"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ivan", 0, "Bezfamilnyi", null, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20d1907f-a723-4d25-b6f8-3c22f85c6e11") },
                    { new Guid("48bc558b-5be3-4082-bce8-36f954017e02"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mariya", 1, "Sidorova", null, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20d1907f-a723-4d25-b6f8-3c22f85c6e11") },
                    { new Guid("345d7722-0d6f-457d-9a51-b62e1c54dd9b"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vitali", 0, "Lukyanov", null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28ac8641-64d2-4e1a-ba39-75c5d78f83ba") },
                    { new Guid("82f4d191-2df3-426b-9f1b-5ca3dee45c46"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elvira", 0, "Zaytseva", null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28ac8641-64d2-4e1a-ba39-75c5d78f83ba") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1db9a73b-ad35-4d1c-adc4-a230cf34cbfc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("345d7722-0d6f-457d-9a51-b62e1c54dd9b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("48bc558b-5be3-4082-bce8-36f954017e02"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("82f4d191-2df3-426b-9f1b-5ca3dee45c46"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e05a0e3c-0e78-4b3a-9f54-30c41feb606f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("eb02287d-3f77-4e20-8fa2-fcc011e83b40"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("20d1907f-a723-4d25-b6f8-3c22f85c6e11"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("28ac8641-64d2-4e1a-ba39-75c5d78f83ba"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("38bef0e0-b9ce-48fe-b0a2-2f799da80788"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("597d92d7-b422-4d58-aec4-ab756604e212"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b5d5b2f6-acff-4caf-b614-885b939a12a3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ed83d408-c681-42c7-bb5e-94e111f9b454"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Students");

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "FirstName", "Gender", "LastName", "LinkToProfile" },
                values: new object[] { new Guid("30bfad55-973f-404f-b5e5-80d5b06f2079"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "FirstName", "Gender", "LastName", "LinkToProfile" },
                values: new object[] { new Guid("cdc235b1-d4f1-4d71-a48b-28f4fe8d0d77"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "FirstName", "Gender", "LastName", "LinkToProfile" },
                values: new object[] { new Guid("91c79154-a504-4e24-a69f-bff96088b090"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2"), new Guid("30bfad55-973f-404f-b5e5-80d5b06f2079"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6"), new Guid("cdc235b1-d4f1-4d71-a48b-28f4fe8d0d77"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "TeacherId", "Title" },
                values: new object[] { new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e"), new Guid("91c79154-a504-4e24-a69f-bff96088b090"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "FirstName", "Gender", "LastName", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("cb96f6c2-ac27-40e9-8e8a-ac3eda194e4b"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii", 0, "Petrov", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2") },
                    { new Guid("24223ec9-8eff-4f19-bbea-62c00510cae0"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr", 0, "Vasiliev", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("461e43fa-46d4-4e1f-b6ac-a2a263f386d2") },
                    { new Guid("2e793b75-0867-425c-a9d5-80e78f5150b9"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", 0, "Bezfamilnyi", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6") },
                    { new Guid("36300be9-9f8c-4dd7-a7d0-c35700829ac9"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya", 1, "Sidorova", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8b450a77-fc6a-4311-9c2e-fe8e3fbe3ab6") },
                    { new Guid("e733ec95-12aa-4c1e-8308-f61fcffa3a1b"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali", 0, "Lukyanov", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e") },
                    { new Guid("0f1d6a47-5778-462d-a242-a7bd347ea65e"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira", 0, "Zaytseva", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ed961c5b-1f05-47de-adca-c97dd5384e2e") }
                });
        }
    }
}
