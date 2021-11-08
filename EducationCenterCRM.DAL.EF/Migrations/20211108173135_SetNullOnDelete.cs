using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationCenterCRM.DAL.EF.Migrations
{
    public partial class SetNullOnDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGroups_StudentGroupId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e2ffcc6-e42e-40db-a77c-44fa83c22825");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcfb967f-20f0-4e53-9367-3c2a63af61a4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3bb64004-434d-4c7e-9c38-b747f49b5907"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b8a323e7-8002-4a81-a4ad-6321ff3b6c8c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("0b0b40e9-b6a3-44c9-a004-de9f4ffaae1b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("4f2e9b1f-1ff9-43e1-be4c-8c50cfa2c8b9"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("52ebfc6b-8080-49f8-b1d1-ded77eeae55e"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("9f0dcc20-b848-44b1-b207-ad50f91480d8"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ea2ea6aa-066c-4195-95e9-890aff580290"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0f868c0a-fc84-4dda-bacd-40316aadb904"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("51e3b74d-33af-4359-82c6-569d2accfe4f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8e275e5c-243c-4fb3-a480-214594dbcf57"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d4596823-8a46-4608-96af-3efab3bc0dbb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f49cc417-500d-4f51-9d35-fa7863e2951c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6fe85cd5-0f64-4a6d-97fe-992ddcbc140e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9f03d7b6-ec13-4f65-9bea-af4ece24d7b3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bc1764d5-4803-4302-bdcc-845d1206ed73"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("ad78301b-639e-423b-b5ff-3ae107662278"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("feee4be9-0eb1-49e4-aab2-35bf3aafa6fb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e817d036-86a2-406e-ac21-34f188ab888d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f86fcbe5-ea94-4b6d-a83a-bfd2b3669453"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3a5ea877-217d-4f74-892a-5cc669fe4b05"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("278a61b6-c7e1-43f2-9177-8c78ae92c3e4"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2bdec0ad-12bd-4833-bc88-1c3d110f6cdf"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4983ccd4-3cdb-4285-9d29-8532afe4a3d5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("184ff06a-7656-47a8-95ce-64a33f6e59d1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7941ba4e-2726-4ef9-a47d-fe11175298bf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8fb9864b-f51d-4218-9884-25d792a8a898"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("11a8e567-a308-4553-9f4c-ffa77a1dccf2"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c5f61478-79e1-4a78-8ab4-7e984ed1c892", 0, "8def06a1-75c8-425c-a245-89b0e444228c", "admin@ECCRM.com", true, false, null, "ADMIN@ECCRM.COM", "ADMIN@ECCRM.COM", "AQAAAAEAACcQAAAAEGqlzbZI01VTvxJap9QfDmyKvlMlX8TkNWg/Ph2HJelObTCljYeM4ATpmr3WvFlf/g==", null, false, "875a5a54-aa00-492a-ad1a-4611d429b7f9", false, "admin@ECCRM.com" },
                    { "44a01cc5-516c-4b13-b1f7-c5ea83187ff5", 0, "566ee57b-81f0-4a62-9a68-c7d50a806cd0", "manager@ECCRM.com", true, false, null, "MANAGER@ECCRM.COM", "MANAGER@ECCRM.COM", "AQAAAAEAACcQAAAAENi73y0hoH5Vy+SUzF70btMSzzxyCDs6lM81FqnYQ13au0w5V4YRYfusPI7ly4DZ5g==", null, false, "e5e0d463-f329-48de-b27d-5118fb73f55e", false, "manager@ECCRM.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Bio", "BirthDate", "Email", "FirstName", "Gender", "LastName", "LinkToProfile", "Phone" },
                values: new object[,]
                {
                    { new Guid("7cfc7c6d-35de-49e3-8786-1812030de236"), "Some information", new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Reshetnikov@gmail.com", "Petr", 0, "Reshetnikov", "https://www.linkedin.com/feed/", "+375(25)6770389" },
                    { new Guid("719935c4-8039-4dc9-bf4a-5e25552a1b24"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikhail_Andreev@gmail.com", "Mikhail", 0, "Andreev", "https://www.linkedin.com/feed/", "+375(25)1132087" },
                    { new Guid("4bc0b368-9166-4f39-bb8d-91760a616604"), "Some other information", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia_Usovich@gmail.com", "Natalia", 1, "Usovich", "https://www.linkedin.com/feed/", "+375(25)8708796" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "ParentId", "ParentId1", "Title" },
                values: new object[,]
                {
                    { new Guid("561822e2-7899-4eab-ae24-5de22678d66b"), ".Net (ASP.NET, Unity)", null, null, ".Net" },
                    { new Guid("eefc85af-67b1-4bc4-9c14-212d10eff8e9"), "JS, HTML, CSS", null, null, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationWeeks", "Price", "Program", "Title", "TopicId" },
                values: new object[,]
                {
                    { new Guid("a4dab732-aad4-4dfe-b69c-dc42f7ff0cad"), "Introduction to C#", 12, 1250m, "1. Getting Started", "Introduction to C#", new Guid("561822e2-7899-4eab-ae24-5de22678d66b") },
                    { new Guid("684e3685-05e2-472a-a072-b196597c18ca"), "Web with ASP.NET", 16, 1350m, "1. Controllers and MVC 2. WebAPI 3.Angular", "ASP.NET", new Guid("561822e2-7899-4eab-ae24-5de22678d66b") },
                    { new Guid("dff5e684-df5f-41de-90d5-28e6514ee3b0"), "Unity Game Development", 16, 1850m, "1. What is Unity", "Unity", new Guid("561822e2-7899-4eab-ae24-5de22678d66b") },
                    { new Guid("b746731e-78cc-45c5-8f41-8c3be2240214"), "Introduction to Java", 4, 1550m, "1. Getting Started", "Introduction to Web", new Guid("eefc85af-67b1-4bc4-9c14-212d10eff8e9") }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571"), new Guid("684e3685-05e2-472a-a072-b196597c18ca"), 0, new Guid("7cfc7c6d-35de-49e3-8786-1812030de236"), "ASP_21-1" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("caf7a532-6e48-4be4-a18a-2dfcf8a8f4c5"), new Guid("684e3685-05e2-472a-a072-b196597c18ca"), 0, new Guid("719935c4-8039-4dc9-bf4a-5e25552a1b24"), "ASP_21-2" });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "CourseId", "Status", "TeacherId", "Title" },
                values: new object[] { new Guid("925f393a-b940-491e-9909-3625d8b322cc"), new Guid("b746731e-78cc-45c5-8f41-8c3be2240214"), 0, new Guid("4bc0b368-9166-4f39-bb8d-91760a616604"), "JS_21-1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "GroupId", "LessonDate" },
                values: new object[,]
                {
                    { new Guid("c6597647-0e00-40a7-94e3-1941e0efa5ab"), new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571"), new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("62550f3d-e9ea-475a-ac34-82c873d452c9"), new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571"), new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d3996a80-68bf-45aa-a7de-a3856c00c52f"), new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571"), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Phone", "StartDate", "StudentGroupId" },
                values: new object[,]
                {
                    { new Guid("16ea2ec3-525b-4134-822b-b69d0cb6ce93"), new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasilii_Petrov@gmail.com", "Vasilii", 0, "Petrov", "+375(25)6361058", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571") },
                    { new Guid("73661f5f-af2a-42a5-a4a7-f583d8dfe40c"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petr_Vasiliev@gmail.com", "Petr", 0, "Vasiliev", "+375(44)2016922", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571") },
                    { new Guid("2f79dd66-fc80-4355-8df7-f8db733ec4d5"), new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Bezfamilnyi@gmail.com", "Ivan", 0, "Bezfamilnyi", "+375(25)8029625", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("caf7a532-6e48-4be4-a18a-2dfcf8a8f4c5") },
                    { new Guid("0ce839fc-c3ca-43f3-bc67-4b03e0d93cc3"), new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariya_Sidorova@gmail.com", "Mariya", 1, "Sidorova", "+375(44)9527231", new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("caf7a532-6e48-4be4-a18a-2dfcf8a8f4c5") },
                    { new Guid("66635683-018b-4656-9551-c5512efa43f1"), new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitali_Lukyanov@gmail.com", "Vitali", 0, "Lukyanov", "+375(29)7524597", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("925f393a-b940-491e-9909-3625d8b322cc") },
                    { new Guid("82a3afdc-d5d3-431e-99b3-2b502bbb336b"), new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvira_Zaytseva@gmail.com", "Elvira", 0, "Zaytseva", "+375(33)5819360", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("925f393a-b940-491e-9909-3625d8b322cc") },
                    { new Guid("2af854a5-06f0-4c19-ab0b-248d37d92744"), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander_Ptichkin@gmail.com", "Alexander", 0, "Ptichkin", "+375(29)8732555", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("925f393a-b940-491e-9909-3625d8b322cc") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "LessonId", "Score", "StudentId" },
                values: new object[,]
                {
                    { new Guid("6d8f8783-0d5e-40e9-98e4-49f21878cef1"), new Guid("c6597647-0e00-40a7-94e3-1941e0efa5ab"), 8, new Guid("16ea2ec3-525b-4134-822b-b69d0cb6ce93") },
                    { new Guid("f25405f1-97cd-4b1d-b8a6-f734e4b93b59"), new Guid("62550f3d-e9ea-475a-ac34-82c873d452c9"), 9, new Guid("16ea2ec3-525b-4134-822b-b69d0cb6ce93") },
                    { new Guid("41ff6b5f-0ec1-4871-87c5-98e17877c79e"), new Guid("c6597647-0e00-40a7-94e3-1941e0efa5ab"), 7, new Guid("73661f5f-af2a-42a5-a4a7-f583d8dfe40c") },
                    { new Guid("c8c863a7-b73a-494e-bf06-596f687d4b47"), new Guid("62550f3d-e9ea-475a-ac34-82c873d452c9"), 7, new Guid("73661f5f-af2a-42a5-a4a7-f583d8dfe40c") },
                    { new Guid("e3d7d2e6-0d39-4a7c-b0f6-1718fb61439c"), new Guid("d3996a80-68bf-45aa-a7de-a3856c00c52f"), 7, new Guid("73661f5f-af2a-42a5-a4a7-f583d8dfe40c") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGroups_StudentGroupId",
                table: "Students",
                column: "StudentGroupId",
                principalTable: "StudentGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGroups_StudentGroupId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a01cc5-516c-4b13-b1f7-c5ea83187ff5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5f61478-79e1-4a78-8ab4-7e984ed1c892");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a4dab732-aad4-4dfe-b69c-dc42f7ff0cad"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dff5e684-df5f-41de-90d5-28e6514ee3b0"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("41ff6b5f-0ec1-4871-87c5-98e17877c79e"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("6d8f8783-0d5e-40e9-98e4-49f21878cef1"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c8c863a7-b73a-494e-bf06-596f687d4b47"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e3d7d2e6-0d39-4a7c-b0f6-1718fb61439c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("f25405f1-97cd-4b1d-b8a6-f734e4b93b59"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0ce839fc-c3ca-43f3-bc67-4b03e0d93cc3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2af854a5-06f0-4c19-ab0b-248d37d92744"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2f79dd66-fc80-4355-8df7-f8db733ec4d5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("66635683-018b-4656-9551-c5512efa43f1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("82a3afdc-d5d3-431e-99b3-2b502bbb336b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("62550f3d-e9ea-475a-ac34-82c873d452c9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c6597647-0e00-40a7-94e3-1941e0efa5ab"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d3996a80-68bf-45aa-a7de-a3856c00c52f"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("925f393a-b940-491e-9909-3625d8b322cc"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("caf7a532-6e48-4be4-a18a-2dfcf8a8f4c5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("16ea2ec3-525b-4134-822b-b69d0cb6ce93"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("73661f5f-af2a-42a5-a4a7-f583d8dfe40c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b746731e-78cc-45c5-8f41-8c3be2240214"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "Id",
                keyValue: new Guid("7737a1f6-5fd5-4447-abf0-2d2a73f04571"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4bc0b368-9166-4f39-bb8d-91760a616604"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("719935c4-8039-4dc9-bf4a-5e25552a1b24"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("684e3685-05e2-472a-a072-b196597c18ca"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7cfc7c6d-35de-49e3-8786-1812030de236"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("eefc85af-67b1-4bc4-9c14-212d10eff8e9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("561822e2-7899-4eab-ae24-5de22678d66b"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGroups_StudentGroupId",
                table: "Students",
                column: "StudentGroupId",
                principalTable: "StudentGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
