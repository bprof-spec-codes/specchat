using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace specchat.API.Migrations
{
    public partial class emoji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Emojis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c64e4fe-73d9-450d-9e8a-0b8ff52d52b0", null, "Admin", "ADMIN" },
                    { "cc1cb33f-4d0f-45df-9fb0-f0d880b0c484", null, "Teacher", "TEACHER" },
                    { "d731b9e0-cbbb-4d4d-9df6-4e9f8ae4a669", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c640ff2-fcfd-45d2-9be7-80a4df6d736f", 0, "9a91a5bd-e858-4637-877f-3271d8764771", "basic@us.er", true, "Basic", "User", false, null, null, "BASICUSER", "AQAAAAEAACcQAAAAEDcJJ7KZP9Iz5lj+6vziTtnYXxiW2KYDDvec/Q7ppllBitaTjH4uIHfdmhdRVQ58Ng==", null, false, null, null, "fa05b256-8e26-4e66-b4b8-8b5037ed60eb", false, "basicuser" },
                    { "87e8cfe1-d303-4ed8-9808-3e3d3794ca85", 0, "4ca56274-337d-498d-bc5f-7420532ee977", "admin@admin.adm", true, "Super", "User", false, null, null, "ADMINUSER", "AQAAAAEAACcQAAAAEHH8LNTBcSJeCYEworc6q+38vlIhpxNT+RIrlAg8G3SVma7ZM+loIP7gr6gC2Lv98Q==", null, false, null, null, "e86fcb25-c460-4d4e-8267-88ddc33917b7", false, "adminuser" },
                    { "d30dbeb3-9bf1-43a8-a3e3-cc7b647eb630", 0, "ce7db66c-28c7-4d74-a87d-e200ef271f5b", "teacher@teach.er", true, "Teacher", "User", false, null, null, "TEACHEREX", "AQAAAAEAACcQAAAAEBntX3fPKZoZr1X7KT5uuFvPgFhbFdcbjdpzNvtwWI/RtG+YHwS/dWFD0a2LAqmssg==", null, false, null, null, "16d91ca5-de7f-45ce-82f8-16c3ddc81240", false, "teacherex" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d731b9e0-cbbb-4d4d-9df6-4e9f8ae4a669", "1c640ff2-fcfd-45d2-9be7-80a4df6d736f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c64e4fe-73d9-450d-9e8a-0b8ff52d52b0", "87e8cfe1-d303-4ed8-9808-3e3d3794ca85" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc1cb33f-4d0f-45df-9fb0-f0d880b0c484", "d30dbeb3-9bf1-43a8-a3e3-cc7b647eb630" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d731b9e0-cbbb-4d4d-9df6-4e9f8ae4a669", "1c640ff2-fcfd-45d2-9be7-80a4df6d736f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c64e4fe-73d9-450d-9e8a-0b8ff52d52b0", "87e8cfe1-d303-4ed8-9808-3e3d3794ca85" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc1cb33f-4d0f-45df-9fb0-f0d880b0c484", "d30dbeb3-9bf1-43a8-a3e3-cc7b647eb630" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c64e4fe-73d9-450d-9e8a-0b8ff52d52b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc1cb33f-4d0f-45df-9fb0-f0d880b0c484");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d731b9e0-cbbb-4d4d-9df6-4e9f8ae4a669");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c640ff2-fcfd-45d2-9be7-80a4df6d736f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87e8cfe1-d303-4ed8-9808-3e3d3794ca85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d30dbeb3-9bf1-43a8-a3e3-cc7b647eb630");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Emojis");

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
        }
    }
}
