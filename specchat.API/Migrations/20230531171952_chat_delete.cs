using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace specchat.API.Migrations
{
    public partial class chat_delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatUsers_Chats_ChatId",
                table: "ChatUsers");

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
                    { "3ca8f2f2-4eae-4b95-855e-a0421d664839", null, "User", "USER" },
                    { "4199cad8-b182-4847-8133-39c4ee1074c3", null, "Teacher", "TEACHER" },
                    { "44433289-fffe-42e0-bba2-b21d54aec8dc", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4749958e-4383-4ede-a19a-8222072b0280", 0, "f23846c8-9177-4b1b-9fbb-af3cafc48edb", "admin@admin.adm", true, "Super", "User", false, null, null, "ADMINUSER", "AQAAAAEAACcQAAAAEC5LNOWjDHv32gf9dKTHiEbdFYNRDwOMz+z+CKpjbsCxbq1f3KbrxgC1V/PySX8koQ==", null, false, null, null, "53e17179-3a39-4273-b6a2-16849747311f", false, "adminuser" },
                    { "8559b2ed-4e06-4e1b-b4ff-1606f001c575", 0, "c8a6942b-a6fa-4750-8006-b0872e414464", "teacher@teach.er", true, "Teacher", "User", false, null, null, "TEACHEREX", "AQAAAAEAACcQAAAAEPHEPmxAgOqrhNKbQ4nWcSfU9yNmvhpOajB9YuS5/uqIxwxseURBpGpWEtguhOXh3Q==", null, false, null, null, "71bdc097-335f-42cc-a2a8-83d8c0cae173", false, "teacherex" },
                    { "d28f77a1-c861-4989-b750-0e644c52865f", 0, "f9106396-2a09-45de-ae7b-5df22f3c0739", "basic@us.er", true, "Basic", "User", false, null, null, "BASICUSER", "AQAAAAEAACcQAAAAEPXt8aVmkrU9E/xeOxH1v7yy8mABx66nqVg1DkNByR8ExII7k3R80IJrZhiinQ2gTw==", null, false, null, null, "79891bf4-bccf-44ab-800c-347f889cca18", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44433289-fffe-42e0-bba2-b21d54aec8dc", "4749958e-4383-4ede-a19a-8222072b0280" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4199cad8-b182-4847-8133-39c4ee1074c3", "8559b2ed-4e06-4e1b-b4ff-1606f001c575" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3ca8f2f2-4eae-4b95-855e-a0421d664839", "d28f77a1-c861-4989-b750-0e644c52865f" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUsers_Chats_ChatId",
                table: "ChatUsers",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatUsers_Chats_ChatId",
                table: "ChatUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44433289-fffe-42e0-bba2-b21d54aec8dc", "4749958e-4383-4ede-a19a-8222072b0280" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4199cad8-b182-4847-8133-39c4ee1074c3", "8559b2ed-4e06-4e1b-b4ff-1606f001c575" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ca8f2f2-4eae-4b95-855e-a0421d664839", "d28f77a1-c861-4989-b750-0e644c52865f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ca8f2f2-4eae-4b95-855e-a0421d664839");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4199cad8-b182-4847-8133-39c4ee1074c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44433289-fffe-42e0-bba2-b21d54aec8dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4749958e-4383-4ede-a19a-8222072b0280");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8559b2ed-4e06-4e1b-b4ff-1606f001c575");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d28f77a1-c861-4989-b750-0e644c52865f");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUsers_Chats_ChatId",
                table: "ChatUsers",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id");
        }
    }
}
