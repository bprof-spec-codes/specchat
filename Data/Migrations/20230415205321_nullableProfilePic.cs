using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace specchat.Migrations
{
    public partial class nullableProfilePic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "73f9905e-4153-4c83-a991-e283dc41a8cd" });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "463417d2-df4f-4714-b896-195e7d8e8e7b");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e5a6a495-a3c6-4d3a-8451-6aff2f208804");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f9905e-4153-4c83-a991-e283dc41a8cd");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "51d4e60b-b763-4f5a-9c0c-aa596c3ff64e");

            migrationBuilder.AddColumn<bool>(
                name: "IsPinned",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PictureContentType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PictureData",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0f013ed5-7d82-4b0a-b409-ccaea75637e9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "14c6c689-094f-45fa-b820-e52db96ec883", 0, "70585baa-ab86-477b-9041-f92d630839aa", "user@gmail.com", true, "Basic", "User", false, null, null, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEF/C9oUqMoG/kcuNtFkvXPQXHsf/HmPzKHyIkSs3QM6WRgXciAQTTFMUeMe4UKzLmg==", null, false, null, null, "e68fef70-d9b7-4d0a-97cf-cbb07f94a723", false, "user@gmail.com" });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "03abea86-d22a-4fdd-a661-93fe44bed6c4", "Beszélgető" },
                    { "0b75a61a-8f00-43b7-af82-4614071d7378", "Játékok" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "14c6c689-094f-45fa-b820-e52db96ec883" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "IsPinned", "MainMessageId", "Time", "UserId" },
                values: new object[] { "c382c4d8-9fde-429b-91d5-396cc3e85565", "03abea86-d22a-4fdd-a661-93fe44bed6c4", "Elso uzenet", false, null, new DateTime(2023, 4, 15, 22, 53, 21, 154, DateTimeKind.Local).AddTicks(2332), "14c6c689-094f-45fa-b820-e52db96ec883" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "14c6c689-094f-45fa-b820-e52db96ec883" });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "0b75a61a-8f00-43b7-af82-4614071d7378");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "c382c4d8-9fde-429b-91d5-396cc3e85565");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c6c689-094f-45fa-b820-e52db96ec883");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "03abea86-d22a-4fdd-a661-93fe44bed6c4");

            migrationBuilder.DropColumn(
                name: "IsPinned",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "PictureContentType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PictureData",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c0ad9632-b5ce-4b5c-965f-0bf6b7abc317");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73f9905e-4153-4c83-a991-e283dc41a8cd", 0, "107bcd85-4fe5-4bc7-87c0-45315eb81fe9", "user@gmail.com", true, "Basic", "User", false, null, null, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEEl5603pqxPoFWoZmqCb2CAHW8CRn4BN2LFGYgJjuBTPKiF+gB9DxzPUfvfqMVU22w==", null, false, "c6d96048-3ff1-4086-898e-e06992d0112f", false, "user@gmail.com" });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "463417d2-df4f-4714-b896-195e7d8e8e7b", "Játékok" },
                    { "51d4e60b-b763-4f5a-9c0c-aa596c3ff64e", "Beszélgető" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "73f9905e-4153-4c83-a991-e283dc41a8cd" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "MainMessageId", "Time", "UserId" },
                values: new object[] { "e5a6a495-a3c6-4d3a-8451-6aff2f208804", "51d4e60b-b763-4f5a-9c0c-aa596c3ff64e", "Elso uzenet", null, new DateTime(2023, 3, 27, 21, 18, 22, 236, DateTimeKind.Local).AddTicks(3747), "73f9905e-4153-4c83-a991-e283dc41a8cd" });
        }
    }
}
