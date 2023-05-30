using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace specchat.API.Migrations
{
    public partial class notmapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8fa25c3e-7ea0-4990-bf7d-bf9afba90b6a", "434ae560-46c7-407b-bc42-c366e7ca6f30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57904da3-ce6b-4e24-8af5-e0119baf42da", "e368860c-9be4-402a-8d5f-cef41b26d9b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a124792-7f2a-4b2f-a5f3-222a4e1a5da0", "f0151a2e-cad2-4b84-b900-232f2cc6c714" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57904da3-ce6b-4e24-8af5-e0119baf42da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a124792-7f2a-4b2f-a5f3-222a4e1a5da0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa25c3e-7ea0-4990-bf7d-bf9afba90b6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "434ae560-46c7-407b-bc42-c366e7ca6f30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e368860c-9be4-402a-8d5f-cef41b26d9b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0151a2e-cad2-4b84-b900-232f2cc6c714");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15f78bf6-95e5-482c-8fb7-3a3c03fe67b5", null, "Teacher", "TEACHER" },
                    { "d9ddb968-42f7-4dd7-b54c-a03ca743ec70", null, "Admin", "ADMIN" },
                    { "fbc877ea-584f-445f-8d8c-8d296b4235cc", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41a8d9e5-2169-4d06-8168-ccbf2e760e98", 0, "aac62a89-980b-440d-af20-c250f3a2ee0e", "teacher@teach.er", true, "Teacher", "User", false, null, null, "TEACHEREX", "AQAAAAEAACcQAAAAEFR5ma2IwOzzWvhKPYoSZoOmc0j8KScogASE2j/HERhtflBwbdlr/2AAjscc/fzS8A==", null, false, null, null, "981e0bab-2c90-47c9-a99d-9625b0e33378", false, "teacherex" },
                    { "950850d4-6de3-4055-b419-04376d72a6dc", 0, "c6aecef5-2e9d-4ff4-9510-82d16e0d9014", "basic@us.er", true, "Basic", "User", false, null, null, "BASICUSER", "AQAAAAEAACcQAAAAEOUrroQ6tEd2MEC9kTFM7+o/KwyauodNwa31xTqMWb3Sa+5rbrWCN5JnX1YVkbpHNA==", null, false, null, null, "738bd87a-3110-47a7-9d13-d96b496e21d5", false, "basicuser" },
                    { "f3a2b49e-8f8b-4118-9d89-7a9edf8980c9", 0, "7b2766c2-b471-4a3e-9c8e-bd5767e8b952", "admin@admin.adm", true, "Super", "User", false, null, null, "ADMINUSER", "AQAAAAEAACcQAAAAEIieUJfMdjJAfuXwqRjuhOLfeeyQJFE6xJ5XkNLIn5cAvKPG7nw4mVqx/nRtQrQuRQ==", null, false, null, null, "eb1f9582-158b-4a02-b138-01d75aa48851", false, "adminuser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15f78bf6-95e5-482c-8fb7-3a3c03fe67b5", "41a8d9e5-2169-4d06-8168-ccbf2e760e98" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fbc877ea-584f-445f-8d8c-8d296b4235cc", "950850d4-6de3-4055-b419-04376d72a6dc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d9ddb968-42f7-4dd7-b54c-a03ca743ec70", "f3a2b49e-8f8b-4118-9d89-7a9edf8980c9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15f78bf6-95e5-482c-8fb7-3a3c03fe67b5", "41a8d9e5-2169-4d06-8168-ccbf2e760e98" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fbc877ea-584f-445f-8d8c-8d296b4235cc", "950850d4-6de3-4055-b419-04376d72a6dc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d9ddb968-42f7-4dd7-b54c-a03ca743ec70", "f3a2b49e-8f8b-4118-9d89-7a9edf8980c9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15f78bf6-95e5-482c-8fb7-3a3c03fe67b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9ddb968-42f7-4dd7-b54c-a03ca743ec70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbc877ea-584f-445f-8d8c-8d296b4235cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41a8d9e5-2169-4d06-8168-ccbf2e760e98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "950850d4-6de3-4055-b419-04376d72a6dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3a2b49e-8f8b-4118-9d89-7a9edf8980c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57904da3-ce6b-4e24-8af5-e0119baf42da", null, "User", "USER" },
                    { "7a124792-7f2a-4b2f-a5f3-222a4e1a5da0", null, "Teacher", "TEACHER" },
                    { "8fa25c3e-7ea0-4990-bf7d-bf9afba90b6a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "434ae560-46c7-407b-bc42-c366e7ca6f30", 0, "33e3955b-c691-4d96-8375-4e9336da199c", "admin@admin.adm", true, "Super", "User", false, null, null, "ADMINUSER", "AQAAAAEAACcQAAAAEF+oqEtp/WLNlMpuzK0JXzQZA8Y7MRrQqwOsxxanqOmAyLspPZU4/w5Jeji5f90Gjw==", null, false, null, null, "22043bca-369f-4ad7-977e-bd89ddf15139", false, "adminuser" },
                    { "e368860c-9be4-402a-8d5f-cef41b26d9b5", 0, "52c0f802-ea17-48ad-bf26-998a88d2fb21", "teacher@teach.er", true, "Teacher", "User", false, null, null, "TEACHEREX", "AQAAAAEAACcQAAAAEErh0ORgc5vlcigQMoy5zKD+adUSguL5649WhdLIvfUZUQlBUhkAOL3SyIl8NOmkdA==", null, false, null, null, "cb92e802-612e-44fb-b552-d82292c34f01", false, "teacherex" },
                    { "f0151a2e-cad2-4b84-b900-232f2cc6c714", 0, "6a37e2ab-85bb-4a86-8cce-d794c575f553", "basic@us.er", true, "Basic", "User", false, null, null, "BASICUSER", "AQAAAAEAACcQAAAAEC3JYzoLzND4wulczIpLlO63VM1GiWCR4AhDi6SCtCLnREdWQYkjHRouOu1PIEyllQ==", null, false, null, null, "ae4ff8c9-e67d-4548-a7c6-b6d5fea3f80e", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8fa25c3e-7ea0-4990-bf7d-bf9afba90b6a", "434ae560-46c7-407b-bc42-c366e7ca6f30" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57904da3-ce6b-4e24-8af5-e0119baf42da", "e368860c-9be4-402a-8d5f-cef41b26d9b5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a124792-7f2a-4b2f-a5f3-222a4e1a5da0", "f0151a2e-cad2-4b84-b900-232f2cc6c714" });
        }
    }
}
