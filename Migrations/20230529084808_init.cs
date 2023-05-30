using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace specchat.Migrations
{
    public partial class init : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
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
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "ChatUsers",
                columns: table => new
                {
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUsers", x => new { x.ChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ChatUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatUsers_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MainMessageId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Messages_MainMessageId",
                        column: x => x.MainMessageId,
                        principalTable: "Messages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emojis",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MessageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emojis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emojis_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Emojis_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "7885a30a-1743-49e1-8759-3aafb70b67d7", null, null },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "156aeba7-d7d6-438d-aca1-abb800d6c81d", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureContentType", "PictureData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00776e64-19cb-4680-a1da-9d5cdc5427da", 0, "78dd898f-91a0-49fa-b0cd-0a499f64f570", "sdoyle4@theatlantic.com", false, "Shea", "Doyle", false, null, null, null, "AQAAAAEAACcQAAAAEJVM15HBdK772yVRdzAMKovERP0CiKGw+HAYMbHHaf/V2jJBNUz4AvDIngIl2RHXvA==", null, false, null, null, "2fe4da4c-cdd6-4eb1-a137-74bd76701873", false, "sdoyle4" },
                    { "0cc87ac7-b789-4313-8865-016c66c804da", 0, "4fe4291e-f94f-4234-aaca-851763a9a4bd", "kgledhillf@ted.com", false, "Kali", "Gledhill", false, null, null, null, "AQAAAAEAACcQAAAAEG7CCK3IK+1VUaugpq5o8NWpQQeOXCBxxZ6pAReAbXDI64oKTY9+hmiAbzYHWO4Ylw==", null, false, null, null, "4e900793-76b3-4012-a679-a94dbc7d8794", false, "kgledhillf" },
                    { "2365c4f3-102b-47db-b5a7-c997b17933d3", 0, "bfd6f9cd-459b-40ad-859c-c2fbba1934cb", "rrodliffj@about.me", false, "Rafaelia", "Rodliff", false, null, null, null, "AQAAAAEAACcQAAAAEJnrr07bdL+wBfV3J0NBCZUn+UNykAasvRUHBJ45dKvrVb/wR2arAuzRofX+QW8sEQ==", null, false, null, null, "ef64b157-a663-4e6a-bb2e-5069ae4648a2", false, "rrodliffj" },
                    { "29488609-754c-47c7-9f27-3734d2f6e5d2", 0, "a3ba4e66-6e5f-43ff-8f16-b1c13ce78cdf", "tizkoveskia@marriott.com", false, "Trudey", "Izkoveski", false, null, null, null, "AQAAAAEAACcQAAAAEH0YG8cwzIecR57J8S9CJBQwgIruG5wQ4s+arQFIXJFBaMQVy5ClCo3x3vL7LEQjgg==", null, false, null, null, "7b7cea0c-6efe-4825-a934-e53cd5225847", false, "tizkoveskia" },
                    { "2c8234c1-3870-46f1-8666-6cdad5ad46ae", 0, "e31c9221-a1cb-464e-b1e4-4bb9b3491ec1", "smccarrell7@xing.com", false, "Salomi", "McCarrell", false, null, null, null, "AQAAAAEAACcQAAAAEDWM824BF7FsY+CBtSyaUpGyRniM5KnONk7+ET+B8teZzroSs6zn+bxdEhX/O4u8yA==", null, false, null, null, "9f76834c-3058-49a6-baea-ac493351e441", false, "smccarrell7" },
                    { "378e0445-5a0b-4dc2-a3ff-d34abc010560", 0, "5818ceba-37fd-4ce4-978b-8fd94a7c9274", "simple@gmail.com", false, "Admin", "User", false, null, null, null, "AQAAAAEAACcQAAAAECDVZ+RRTw1q+w/DHUBlc8AXQNV1Kz/11D/yOvFwWP5rzSSFL5r5T+ZmPRNvk3OA9Q==", null, false, null, null, "b4852a59-7dc7-4402-a8c7-b007323ab13d", false, "simple@gmail.com" },
                    { "3a8fdb7e-97e5-4712-82d0-40aabeccaf22", 0, "ce66cf79-2e8f-4853-9d9b-8c72b1c3738f", "kbraham3@nationalgeographic.com", false, "Kirsti", "Braham", false, null, null, null, "AQAAAAEAACcQAAAAEMX/0d0fPxIRvsWILAsRms89IewcqO2dcD9+leUSSdpX63TNCcsV0iAI8BN/DD1Q/Q==", null, false, null, null, "ee6107e9-8a70-465a-983c-8e9840fc5a69", false, "kbraham3" },
                    { "617d4034-d51a-44ee-a75c-88b693c15153", 0, "1e03c912-01a0-4a71-8e64-4d68095681af", "spankettman9@histats.com", false, "Sammie", "Pankettman", false, null, null, null, "AQAAAAEAACcQAAAAEBQP7J1arETDyKlkihIE/yf2abWG1Ub5zFAwgxNJ3B429nq7qCxvjXdrchICj28rzw==", null, false, null, null, "7b548c90-cf57-47b9-8ab7-fb194a2bf6d1", false, "spankettman9" },
                    { "65f19b8d-7b56-4f5a-b250-505856048ee9", 0, "4694427a-3cb1-406a-bc55-96f6afe0ed6d", "msandiland1@blogtalkradio.com", false, "Millard", "Sandiland", false, null, null, null, "AQAAAAEAACcQAAAAEC7bm/QPa7Q+mgB0OJUbU2isZcS3unnrCo6lEypbkBf52B17qpI62rK49rkdq3kP2A==", null, false, null, null, "3fd52dc5-15e4-450f-894d-99ef17c20fd5", false, "msandiland1" },
                    { "697f92b1-85c3-4376-8b86-4d0b90d77ac7", 0, "88d5cd15-9d04-4d42-abde-a7a713d3e000", "fgraeber8@icio.us", false, "Fletch", "Graeber", false, null, null, null, "AQAAAAEAACcQAAAAEOCmxdTW/xY04Gi2Lq4LB9x7w/vFP9DXh1c76u8Fg56bwpfKfMMvYhpnUtjr3UqxPQ==", null, false, null, null, "6da875fe-d583-48e3-ba58-5eea35e2c92e", false, "fgraeber8" },
                    { "77c5764f-c7de-4453-9e44-ee7d42a7379a", 0, "8a3a3498-3987-4bdf-9e06-1241875d54e8", "gouchterlony5@unc.edu", false, "Gregorio", "Ouchterlony", false, null, null, null, "AQAAAAEAACcQAAAAECd43T9W0+GkJ0336N1SJEgzcbmd5vBgwqMX5f6VH3nEj7GUAKJfVVe0pvnVgpvdFA==", null, false, null, null, "54a58168-9358-48fb-88c7-c5c5529fa9de", false, "gouchterlony5" },
                    { "89ee0b02-1be7-428e-bbac-2ae68ce90cbf", 0, "ccff80f3-4c97-4d75-af94-cfa89ecfdfbf", "user@gmail.com", true, "Basic", "User", false, null, null, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEAC1i4O4c4IS/i1teNbnAvgxvW/4yVVi/RE6rNQLYGr3BqC9053jV29tvzuMs7c1pg==", null, false, null, null, "0086c1fa-434c-4f7c-9ffa-67aefe0c8c90", false, "user@gmail.com" },
                    { "a5817690-b4f6-4f08-93f7-c95f0d086003", 0, "a317d3be-3d72-4608-8db2-8be57fbd856f", "jcoopper2@nyu.edu", false, "Jolene", "Coopper", false, null, null, null, "AQAAAAEAACcQAAAAEHS/S3h9lat6HwS2fpc/GeZVFSp/BuJdHsxfkKcNgmYendrnWnfSb5rRiAAHojEW1Q==", null, false, null, null, "d843d0ff-9d45-464e-83f3-d6430cf27510", false, "jcoopper2" },
                    { "b204ffa6-191a-4a5d-a740-b0918930f7cf", 0, "1526b72a-0b46-496c-b546-cd1a48dd9ca9", "cdominicoe@de.vu", false, "Curcio", "Dominico", false, null, null, null, "AQAAAAEAACcQAAAAEPTUQRFgnyWG8GLJXJIgTZFmFlpztxwPpD0shLLdMXF3VQyoJRQjJ6cddpRVEhRJaQ==", null, false, null, null, "fe9631b4-2f75-49bc-a7e7-2275f8af454c", false, "cdominicoe" },
                    { "b42cb718-ba98-4a24-a00a-f45a5b14b424", 0, "c198ebac-478c-4a7d-b31d-fda3ba406a58", "mtrumph@harvard.edu", false, "Mervin", "Trump", false, null, null, null, "AQAAAAEAACcQAAAAEGj85TXXCxW9U2Ww0/DooacSIm/L2pJy0wxs9h6WXQJ+EPrx43sEaS7j1+pBb2FzIw==", null, false, null, null, "7584267c-bb05-4225-9bea-9b6d2c75dcec", false, "mtrumph" },
                    { "b8126356-c38e-4b7d-9a81-7203cf11e7ee", 0, "d6cef2b8-320a-4726-984e-ad2dbd9fa733", "ejinkind@irs.gov", false, "Ernesto", "Jinkin", false, null, null, null, "AQAAAAEAACcQAAAAECHnaUwWSDLUuqPlE33f9/2q54A30H/JMsYe9RSEmGwmQC2ubxTkrTY+BojTjIiYxQ==", null, false, null, null, "62d22293-9123-4f6b-8e48-3cf7b0664a54", false, "ejinkind" },
                    { "b993f12a-f0c8-4d01-bf63-14435fad67c7", 0, "e76e2687-2b29-45f1-b7f6-b536a6843701", "aconnerry6@godaddy.com", false, "Alma", "Connerry", false, null, null, null, "AQAAAAEAACcQAAAAEJCJOhVFQqP7S2fEL+LOyZV2NRCEJFRkAHvQwy1ebj7A0TfQNl0ad48lN4/wo3gRFw==", null, false, null, null, "6c5533cb-70f2-4a8b-b723-deda3022b07b", false, "aconnerry6" },
                    { "c8364e69-e449-45ba-b471-c05cddc23e73", 0, "c8ce7925-fa48-40a0-bdcc-4eed17069fc7", "msmailsc@reddit.com", false, "Moina", "Smails", false, null, null, null, "AQAAAAEAACcQAAAAEJgqfHLJ6nJlzRnRnvaTowcZgWxYxgvaCk3c0rusIiZ2uHjmUNPOvGrmXIpPx5R6DA==", null, false, null, null, "cf4eb738-821a-455a-bf3f-640d4ca8dce3", false, "msmailsc" },
                    { "cc6860e6-34fa-4afd-8750-5990a525ed41", 0, "e3caa5a0-d5d4-4bf1-b741-0de1ec877364", "beaglesi@over-blog.com", false, "Benito", "Eagles", false, null, null, null, "AQAAAAEAACcQAAAAEOdOtqDaKfXl97HSpDOELBk0TMWwSInZUbNDr532ASCvMbaT/rnqNC8kjDQtnakuPA==", null, false, null, null, "50dab878-ee42-4838-bf92-77de4bf503db", false, "beaglesi" },
                    { "da283588-5c64-4124-b2bb-81bb4ba1225b", 0, "1678aa6b-ad74-4360-9386-55dffb97b3af", "rhaldeneg@illinois.edu", false, "Richard", "Haldene", false, null, null, null, "AQAAAAEAACcQAAAAEBfGnCJtrH7prBfF2AFQyG86PWO5vsNw0l+891D5XtdqcRs0uL4Hyo6p/CCbXhbJzA==", null, false, null, null, "3e68b61f-35de-4992-a1f8-63a8ff103557", false, "rhaldeneg" },
                    { "e08c564a-9612-4b4b-bda4-f2d10a51efd0", 0, "85f1fd21-8ab6-4df9-96a3-b63ae87f4a37", "teacher@gmail.com", false, "Teacher", "Teacher_last", false, null, null, null, "AQAAAAEAACcQAAAAEOMRnBdPRqp1D7cWsNHglPX4gUwB5GaBOGckuJRNR+Qq3JBFG/2qk6tlfvL2ydm92g==", null, false, null, null, "a97bfeb0-1ce2-43f2-95d0-ef748ef2aafa", false, "teacher@gmail.com" },
                    { "e09ab5c5-f6d3-4db9-8de8-f253f0d51637", 0, "1b0c49fe-902c-4964-86f2-dedcfcf68d26", "aiashvilib@chronoengine.com", false, "Abigael", "Iashvili", false, null, null, null, "AQAAAAEAACcQAAAAEAUVdBrLP+I6M3Oe34I7tRBoQITGx7azUD//AMF34BOw/oNo7pHs3fRmAU0n3E1IYA==", null, false, null, null, "3db0cbb5-3ae8-427d-82f3-02ee45e64865", false, "aiashvilib" },
                    { "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3", 0, "aeeac650-10de-489e-a108-3798e195bbf1", "nsollner0@tmall.com", false, "Naoma", "Sollner", false, null, null, null, "AQAAAAEAACcQAAAAEJMfX/sfBf3exZK2baHTssJCkCNoh9dOSdIfG2iWOTt+qrFqdLReyXCtk6IZBi8MsQ==", null, false, null, null, "680baeb6-f140-4dfb-be4d-6682c7334883", false, "nsollner0" },
                    { "fc27a590-b551-4a5f-a0ba-d6b423ba8c82", 0, "bfccd850-e725-4b6c-900b-27cafb395d23", "user@gmail.com", false, "Basic", "User", false, null, null, null, "AQAAAAEAACcQAAAAEEeb22xvvgKxT1rROhu333JosAb+Bb6B7KNJPtHovpjbOZZ8wQcy0uyc1FtzpevzJw==", null, false, null, null, "6adaf65e-250b-4d8b-9ab8-c578842809f9", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Játékok" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Alamónium" },
                    { "28c07e65-9fb0-4900-9cd9-faa3f97704d9", "Support" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "Engineering" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "Marketing" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "Product Management" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "Engineering" },
                    { "a4e1ade6-03db-497e-b12b-467a5f4bc130", "Services" },
                    { "b8797f95-cc86-47bd-b4e3-4edd7a7dba24", "Training" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "Research and Development" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "Product Management" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Beszélgető" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "Human Resources" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "00776e64-19cb-4680-a1da-9d5cdc5427da" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "a5817690-b4f6-4f08-93f7-c95f0d086003" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "a5817690-b4f6-4f08-93f7-c95f0d086003" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "246904db-4b9c-410c-93cb-090b3fa93c9f", "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "f0fb3eeb-4385-4952-83e9-4ccaf78b9064", "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" }
                });

            migrationBuilder.InsertData(
                table: "ChatUsers",
                columns: new[] { "ChatId", "UserId" },
                values: new object[,]
                {
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "00776e64-19cb-4680-a1da-9d5cdc5427da" },
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "617d4034-d51a-44ee-a75c-88b693c15153" },
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "06529009-e3f0-48a3-a57a-86b61b71cf9f", "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "28c07e65-9fb0-4900-9cd9-faa3f97704d9", "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "28c07e65-9fb0-4900-9cd9-faa3f97704d9", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" }
                });

            migrationBuilder.InsertData(
                table: "ChatUsers",
                columns: new[] { "ChatId", "UserId" },
                values: new object[,]
                {
                    { "28c07e65-9fb0-4900-9cd9-faa3f97704d9", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "28c07e65-9fb0-4900-9cd9-faa3f97704d9", "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "28c07e65-9fb0-4900-9cd9-faa3f97704d9", "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "00776e64-19cb-4680-a1da-9d5cdc5427da" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "70f0f02d-83de-490b-b42d-e37fff244f77", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "76d422c9-6d26-42a4-a24b-aae84b4ad0ae", "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "00776e64-19cb-4680-a1da-9d5cdc5427da" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "856cb1b1-7b59-4782-b35c-4bb1344788fa", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "a5817690-b4f6-4f08-93f7-c95f0d086003" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "9ff197fe-35a1-450c-978e-2e0bd500668b", "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "a4e1ade6-03db-497e-b12b-467a5f4bc130", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "a4e1ade6-03db-497e-b12b-467a5f4bc130", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "a4e1ade6-03db-497e-b12b-467a5f4bc130", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "a4e1ade6-03db-497e-b12b-467a5f4bc130", "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "a4e1ade6-03db-497e-b12b-467a5f4bc130", "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "b8797f95-cc86-47bd-b4e3-4edd7a7dba24", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "b8797f95-cc86-47bd-b4e3-4edd7a7dba24", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "b8797f95-cc86-47bd-b4e3-4edd7a7dba24", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "0cc87ac7-b789-4313-8865-016c66c804da" }
                });

            migrationBuilder.InsertData(
                table: "ChatUsers",
                columns: new[] { "ChatId", "UserId" },
                values: new object[,]
                {
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "617d4034-d51a-44ee-a75c-88b693c15153" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "cc232931-57f3-4681-84fd-3d34c524f816", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "e2da4790-1523-410e-a47b-e8323ad4a4f6", "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "a5817690-b4f6-4f08-93f7-c95f0d086003" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "617d4034-d51a-44ee-a75c-88b693c15153" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "IsPinned", "MainMessageId", "Time", "UserId" },
                values: new object[,]
                {
                    { "074f0533-93d1-4508-b10c-efc88819972d", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.\n\nMaecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", true, null, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2365c4f3-102b-47db-b5a7-c997b17933d3" },
                    { "095bf0a3-8641-45c6-a77b-ffd10a780f85", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.\n\nMaecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.\n\nNullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.", false, null, new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "107cb282-0672-4aaf-a2cf-e86254aabc5c", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.\n\nCurabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", true, null, new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "23cb9993-6cf1-4a3a-aedc-57d89ce416f6", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.\n\nVestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.\n\nIn congue. Etiam justo. Etiam pretium iaculis justo.", true, null, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "2821746f-8821-41ff-b570-e76f1da6dc8a", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.", false, null, new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "2b92dca8-b2c2-4e95-9621-2cc467cbe963", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.\n\nIn sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.\n\nSuspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.", false, null, new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "2c61dfa5-fd60-456d-acf5-6d652f618e2d", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.", true, null, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "2f5a6bfb-4a88-4a78-a140-daae81491507", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.\n\nMorbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", false, null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "2f84d74b-0cdc-46ee-b623-e522fc8ddef5", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.", true, null, new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "617d4034-d51a-44ee-a75c-88b693c15153" },
                    { "3106de78-0e18-4d6d-b14d-54d0ea22bb67", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.\n\nQuisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.\n\nVestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.", false, null, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "354a9b4c-cb88-414b-b27e-4c8496f92c38", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.", true, null, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "da283588-5c64-4124-b2bb-81bb4ba1225b" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "IsPinned", "MainMessageId", "Time", "UserId" },
                values: new object[,]
                {
                    { "358b79d5-dcbe-40d7-b8d4-5b186d454be8", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.\n\nQuisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.", false, null, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "3bfdde7e-c8e0-4965-b850-e5c56e05b44e", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", true, null, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "3c8ac2c8-b8e4-4799-a74d-34831e8b2850", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.\n\nMaecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.\n\nNullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.", true, null, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "3f03dd02-2860-4c6f-a9f8-730f45477520", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", true, null, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "45ab570a-099a-43fd-bfbd-c6d6b83cace7", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.\n\nPhasellus in felis. Donec semper sapien a libero. Nam dui.", true, null, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "4ed097f0-4226-43ec-944b-ddaf585f55a7", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", true, null, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "560a5d4f-eaba-48dc-94e0-c56efa6a6cf2", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Sed ante. Vivamus tortor. Duis mattis egestas metus.\n\nAenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.\n\nQuisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", false, null, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "565b6b55-2746-4021-96a0-386f650994f7", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\n\nEtiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.", true, null, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "5743513b-b6c2-4561-ab64-a44c18d7abc5", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.", false, null, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "5c2d32a6-d0be-4fea-ac6f-705bad70e2f4", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus.\n\nVestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.\n\nDuis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.", true, null, new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "5e675ecf-bc48-4354-9282-dbc64a5e9c00", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.\n\nNam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.\n\nCurabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", false, null, new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "607d986c-0ec0-4a5f-b0f4-f7dfcfcb98a7", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.\n\nMaecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", true, null, new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "6642b95a-f48d-4b62-8671-6bd2bbef0a80", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.\n\nPhasellus in felis. Donec semper sapien a libero. Nam dui.\n\nProin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", true, null, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "685a03e4-c9a9-4ccb-9348-ce828940f710", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.\n\nMaecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", true, null, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "69c099c7-54b3-4d14-b04c-a8ac207959d7", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Elso uzenet", false, null, new DateTime(2023, 5, 9, 13, 10, 35, 392, DateTimeKind.Unspecified).AddTicks(4498), "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "6d8bfd4a-c284-489f-8791-62df040689f5", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "In congue. Etiam justo. Etiam pretium iaculis justo.\n\nIn hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.\n\nNulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.", false, null, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "6ddb6650-1ae2-4fd1-88eb-0fffb1dbe343", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.\n\nPhasellus in felis. Donec semper sapien a libero. Nam dui.\n\nProin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", false, null, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "784d5ee4-2e61-4048-ac94-b63ae65694f3", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Fusce consequat. Nulla nisl. Nunc nisl.\n\nDuis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.", false, null, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "7b783a2a-f24e-42d8-a920-a3181aecc478", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.\n\nNam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.\n\nCurabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", true, null, new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "84b14fed-aa0e-444c-a6bb-dbad73296c06", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Phasellus in felis. Donec semper sapien a libero. Nam dui.\n\nProin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.\n\nInteger ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.", false, null, new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "a5817690-b4f6-4f08-93f7-c95f0d086003" },
                    { "8a502bfc-4eb4-4c0e-9656-3077898618c4", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", false, null, new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "915f7c3f-5366-4709-aa51-b050fc058d8d", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.\n\nNam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.\n\nCurabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", false, null, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "91899534-74ba-4ad3-b0b4-5b46504ad846", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "harmadik uzenet", false, null, new DateTime(2023, 5, 9, 13, 10, 35, 392, DateTimeKind.Unspecified).AddTicks(4574), "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "9439dc95-2b99-4a72-aab5-649ee6eb9a47", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.\n\nPellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.", false, null, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "9af993c0-9b17-41c7-8a26-6ca57102f1fe", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.", true, null, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "9b069e30-529a-4b1f-9dc7-f9324f162838", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.\n\nMaecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.\n\nNullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.", false, null, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "a47934d6-b4a5-4927-a66a-9587fba11cbe", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.\n\nNullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.\n\nMorbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", false, null, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "a85b786b-d52e-45f3-8c03-fa28567645f8", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.\n\nMaecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", false, null, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "a87cd16f-1fc7-4256-be47-0440a6feb6c3", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.", true, null, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "a8bb2ca1-e2c7-4e84-a3b8-38433adcc553", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.\n\nInteger tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.\n\nPraesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", false, null, new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "a9a261ff-5055-4a53-b3e9-9d46e4cc0a6a", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.", true, null, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "cf4e852e-029d-4242-8dc7-7039bc8ae4aa", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.\n\nIn hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.\n\nAliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", true, null, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "617d4034-d51a-44ee-a75c-88b693c15153" },
                    { "d0312645-a3ea-4af8-9e8c-58294814e708", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Masodik Uzenet", false, null, new DateTime(2023, 5, 9, 13, 10, 35, 392, DateTimeKind.Unspecified).AddTicks(4565), "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" },
                    { "d14a6524-1beb-410d-ae12-85568881d45d", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.\n\nPhasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.\n\nProin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", false, null, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "d83b8e11-7eea-4737-8443-8ca7be4b5ef4", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", true, null, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "da7a5de2-3cd1-4411-a171-d2843e9fee9c", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", false, null, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "dda4ab57-438c-4ce2-b35e-1b201b3b9083", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.\n\nPhasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", false, null, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "df8d2491-ee0b-47eb-87e3-0baf55353791", "e4a93b77-7cb4-455f-b826-86bf3fbdf79e", "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", true, null, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "dfe64632-cdea-4cb8-abda-31f9d74f11be", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.\n\nFusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.\n\nSed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.", false, null, new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "e5f97b0a-0fbc-4e24-9362-dfe2790ea547", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", false, null, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "fc02cf96-8de6-4c2f-b2be-ced80d86ae5f", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Sed ante. Vivamus tortor. Duis mattis egestas metus.\n\nAenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.\n\nQuisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", false, null, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "fe908d97-b55b-479a-a280-0fb87d7c9a5a", "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", false, null, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0cc87ac7-b789-4313-8865-016c66c804da" }
                });

            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "MessageId", "UserId" },
                values: new object[,]
                {
                    { "013b10ea-58d0-4c4d-b386-b41906ad9de9", "354a9b4c-cb88-414b-b27e-4c8496f92c38", "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "0a00fcd3-675e-4da3-958e-cac872290fa8", "5743513b-b6c2-4561-ab64-a44c18d7abc5", "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "0e801a82-dccd-40d1-8ff4-86bf1fd867d1", "45ab570a-099a-43fd-bfbd-c6d6b83cace7", "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "16dd6548-64f0-469a-b7a5-f81a71a650d6", "5743513b-b6c2-4561-ab64-a44c18d7abc5", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "1cc0e2f2-dc07-41ab-a19a-c7057cade70d", "dda4ab57-438c-4ce2-b35e-1b201b3b9083", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "21cc6889-21ce-4756-b6b0-aae42f189e13", "3106de78-0e18-4d6d-b14d-54d0ea22bb67", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "256f07b6-8acb-4337-a4e9-f109b0b7b023", "6642b95a-f48d-4b62-8671-6bd2bbef0a80", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "26266ee3-b0e6-4dfe-8497-8dca36b2d3c4", "784d5ee4-2e61-4048-ac94-b63ae65694f3", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "3727c821-73a3-45b8-8064-e48d552e39b6", "358b79d5-dcbe-40d7-b8d4-5b186d454be8", "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "40f46894-4d2e-42a7-83f1-ec2720b2838f", "607d986c-0ec0-4a5f-b0f4-f7dfcfcb98a7", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "455a0a5e-26fa-46cb-bf25-b08e1383bf66", "91899534-74ba-4ad3-b0b4-5b46504ad846", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "49661372-47d7-4d0a-9644-03d4c47fdfa1", "107cb282-0672-4aaf-a2cf-e86254aabc5c", "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "51d70dcd-6a05-4897-b944-aa8768710b7a", "69c099c7-54b3-4d14-b04c-a8ac207959d7", "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "5451d33d-7cf2-4b63-acaf-a1b77e8d8932", "358b79d5-dcbe-40d7-b8d4-5b186d454be8", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "5c90e629-4733-440b-9ec6-2b3c3e566db1", "5743513b-b6c2-4561-ab64-a44c18d7abc5", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "5f499744-7fa0-43c2-ad2f-7a154205b0f5", "2c61dfa5-fd60-456d-acf5-6d652f618e2d", "77c5764f-c7de-4453-9e44-ee7d42a7379a" },
                    { "680966ba-43a6-48ae-9379-20203b846e79", "dda4ab57-438c-4ce2-b35e-1b201b3b9083", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" },
                    { "6f38eabc-9f9e-48cf-b274-d6212ee4ce33", "2f5a6bfb-4a88-4a78-a140-daae81491507", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "75d525a0-bb26-4ac7-adc4-39333ca58eee", "2821746f-8821-41ff-b570-e76f1da6dc8a", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "7a39d189-4907-4aa9-8679-590979098955", "915f7c3f-5366-4709-aa51-b050fc058d8d", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "7d70d32e-344b-442a-bada-9dc52950d9eb", "354a9b4c-cb88-414b-b27e-4c8496f92c38", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "821124c7-6c6c-4c7a-a8d1-35a8049a209b", "607d986c-0ec0-4a5f-b0f4-f7dfcfcb98a7", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "860ef463-f407-4d2c-8943-0b6b2ca207ce", "6d8bfd4a-c284-489f-8791-62df040689f5", "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "8ae57e2d-a893-4720-9d14-a65705207440", "3bfdde7e-c8e0-4965-b850-e5c56e05b44e", "b993f12a-f0c8-4d01-bf63-14435fad67c7" },
                    { "8c5e8d75-b995-446b-8406-6ccf8cffc9a3", "4ed097f0-4226-43ec-944b-ddaf585f55a7", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "8e2c4f11-7ea7-4f25-aa1b-2d347881f273", "d0312645-a3ea-4af8-9e8c-58294814e708", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "8f782f90-a36c-45ab-aa24-b659daac4ace", "84b14fed-aa0e-444c-a6bb-dbad73296c06", "29488609-754c-47c7-9f27-3734d2f6e5d2" },
                    { "92f7f76e-3224-4b5c-af3f-98ae863631d3", "a47934d6-b4a5-4927-a66a-9587fba11cbe", "65f19b8d-7b56-4f5a-b250-505856048ee9" },
                    { "932e5da8-5e66-4eac-bf86-b709ea8ae213", "2821746f-8821-41ff-b570-e76f1da6dc8a", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "94912465-d667-4f1b-a8e6-31c63d22f310", "6d8bfd4a-c284-489f-8791-62df040689f5", "3a8fdb7e-97e5-4712-82d0-40aabeccaf22" },
                    { "9bac2cf3-f6dd-472e-a957-cc6e036cdc93", "9b069e30-529a-4b1f-9dc7-f9324f162838", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "a7bef33f-c547-4da9-b972-3dce78dbe6cc", "685a03e4-c9a9-4ccb-9348-ce828940f710", "b8126356-c38e-4b7d-9a81-7203cf11e7ee" },
                    { "b20babfa-b5f3-4cb7-8aac-3ff3538b7953", "a85b786b-d52e-45f3-8c03-fa28567645f8", "e08c564a-9612-4b4b-bda4-f2d10a51efd0" },
                    { "b2bde229-bd80-4aee-bb91-5b693a08d773", "354a9b4c-cb88-414b-b27e-4c8496f92c38", "da283588-5c64-4124-b2bb-81bb4ba1225b" },
                    { "b8dd4b23-ec7c-46cb-96b6-77a19721ac71", "3106de78-0e18-4d6d-b14d-54d0ea22bb67", "e09ab5c5-f6d3-4db9-8de8-f253f0d51637" },
                    { "c647fd5d-655b-4d62-b4f3-197fedd4991f", "7b783a2a-f24e-42d8-a920-a3181aecc478", "e538a8ed-a181-47d6-8b2e-4ac2fd57bad3" },
                    { "d2b8336f-a55b-4182-9b91-91d5fda7759d", "7b783a2a-f24e-42d8-a920-a3181aecc478", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "e0361dfd-d0a3-48f5-8e84-2aec99bac94e", "2f5a6bfb-4a88-4a78-a140-daae81491507", "c8364e69-e449-45ba-b471-c05cddc23e73" },
                    { "e5f1f745-62e7-4fdd-96b3-431b32d1f9a9", "2821746f-8821-41ff-b570-e76f1da6dc8a", "b42cb718-ba98-4a24-a00a-f45a5b14b424" },
                    { "e5ffb2d8-571e-4ff6-b071-6cb25f7770e3", "d83b8e11-7eea-4737-8443-8ca7be4b5ef4", "697f92b1-85c3-4376-8b86-4d0b90d77ac7" },
                    { "e754b273-9e88-4081-a546-a79c105a2757", "2821746f-8821-41ff-b570-e76f1da6dc8a", "378e0445-5a0b-4dc2-a3ff-d34abc010560" },
                    { "e84c660d-7df1-44cb-a770-eb74fc48f80b", "6ddb6650-1ae2-4fd1-88eb-0fffb1dbe343", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" }
                });

            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "MessageId", "UserId" },
                values: new object[,]
                {
                    { "eb0d4e64-e2ad-430b-98b5-5704b77430ee", "2821746f-8821-41ff-b570-e76f1da6dc8a", "0cc87ac7-b789-4313-8865-016c66c804da" },
                    { "ec851559-045d-454e-8c55-23c11ae9b804", "3106de78-0e18-4d6d-b14d-54d0ea22bb67", "617d4034-d51a-44ee-a75c-88b693c15153" },
                    { "f0f68f77-cc51-42dd-86e8-bff18ec75ee4", "2821746f-8821-41ff-b570-e76f1da6dc8a", "cc6860e6-34fa-4afd-8750-5990a525ed41" },
                    { "f7b66a51-77ea-4c93-9f65-956b9dc9f487", "685a03e4-c9a9-4ccb-9348-ce828940f710", "b204ffa6-191a-4a5d-a740-b0918930f7cf" },
                    { "f92d6046-cb78-45ba-80c9-4b5513913984", "df8d2491-ee0b-47eb-87e3-0baf55353791", "29488609-754c-47c7-9f27-3734d2f6e5d2" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "IsPinned", "MainMessageId", "Time", "UserId" },
                values: new object[] { "808bfed0-d047-4788-afa9-18d6db937b57", "06529009-e3f0-48a3-a57a-86b61b71cf9f", "negyedik uzenet", false, "91899534-74ba-4ad3-b0b4-5b46504ad846", new DateTime(2023, 5, 9, 13, 10, 35, 392, DateTimeKind.Unspecified).AddTicks(4583), "fc27a590-b551-4a5f-a0ba-d6b423ba8c82" });

            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "MessageId", "UserId" },
                values: new object[] { "9a16392a-4533-4993-b8ee-4f741aa4e86c", "808bfed0-d047-4788-afa9-18d6db937b57", "697f92b1-85c3-4376-8b86-4d0b90d77ac7" });

            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "MessageId", "UserId" },
                values: new object[] { "ddfdc158-9477-4c01-8c9a-e20caa9b79a9", "808bfed0-d047-4788-afa9-18d6db937b57", "2c8234c1-3870-46f1-8666-6cdad5ad46ae" });

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
                name: "IX_ChatUsers_UserId",
                table: "ChatUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Emojis_MessageId",
                table: "Emojis",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Emojis_UserId",
                table: "Emojis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MainMessageId",
                table: "Messages",
                column: "MainMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });
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
                name: "ChatUsers");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Emojis");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Chats");
        }
    }
}
