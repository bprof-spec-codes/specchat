using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace specchat.API.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "68fd8a93-466b-4e68-bc7d-1b955e7df30c", null, "Admin", "ADMIN" },
                    { "87d04b58-8700-479e-81c2-15c2292a4426", null, "User", "USER" },
                    { "bb105dac-e493-4df9-b46f-ceec45354b28", null, "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "597eb7dc-9d1a-4b7d-89c7-11decff15ce7", 0, "6cfd1d4d-2cc9-48c0-99ac-be2fda69933b", "admin@admin.adm", true, "Super", "User", false, null, null, "ADMINUSER", "AQAAAAEAACcQAAAAELaVkvyYilZkXoylkv9F8qTU62zNd2Lggk2kmvkysixjCxNrRKReFQ2PONoa08CE2g==", null, false, null, null, "60904ce4-eb50-4321-98fd-c212b5095004", false, "adminuser" },
                    { "73f7badf-20b3-4401-9585-4d407e8f71ac", 0, "89bbc5c0-d90b-4894-802d-08f44f49d65b", "basic@us.er", true, "Basic", "User", false, null, null, "BASICUSER", "AQAAAAEAACcQAAAAEP6xnbBUpOzHtVmTt33Du66PDa3Sem0h1r80tVfTYTPz7D6b8wJpiSSh3HlTCSjJqA==", null, false, null, null, "07a9c20d-17af-4b8b-92ce-fb7fe7489e23", false, "basicuser" },
                    { "b76032f3-96a3-4164-b534-84d784d361a3", 0, "e4c8dfe0-ded1-4b4c-b81a-01463777cda9", "teacher@teach.er", true, "Teacher", "User", false, null, null, "TEACHEREX", "AQAAAAEAACcQAAAAEBT5eY5iNZ5kLaVncGs4I1taV5LkRtLz8CskPywXIns3JDNwlT9qObq2kLWtXV1pFw==", null, false, null, null, "9e5de061-e06d-4d49-94a9-12d1a38fb1b5", false, "teacherex" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "68fd8a93-466b-4e68-bc7d-1b955e7df30c", "597eb7dc-9d1a-4b7d-89c7-11decff15ce7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "87d04b58-8700-479e-81c2-15c2292a4426", "73f7badf-20b3-4401-9585-4d407e8f71ac" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb105dac-e493-4df9-b46f-ceec45354b28", "b76032f3-96a3-4164-b534-84d784d361a3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68fd8a93-466b-4e68-bc7d-1b955e7df30c", "597eb7dc-9d1a-4b7d-89c7-11decff15ce7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87d04b58-8700-479e-81c2-15c2292a4426", "73f7badf-20b3-4401-9585-4d407e8f71ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb105dac-e493-4df9-b46f-ceec45354b28", "b76032f3-96a3-4164-b534-84d784d361a3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68fd8a93-466b-4e68-bc7d-1b955e7df30c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87d04b58-8700-479e-81c2-15c2292a4426");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb105dac-e493-4df9-b46f-ceec45354b28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "597eb7dc-9d1a-4b7d-89c7-11decff15ce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f7badf-20b3-4401-9585-4d407e8f71ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b76032f3-96a3-4164-b534-84d784d361a3");

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
    }
}
