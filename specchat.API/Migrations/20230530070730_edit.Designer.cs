﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using specchat.API.Data;

#nullable disable

namespace specchat.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230530070730_edit")]
    partial class edit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "68fd8a93-466b-4e68-bc7d-1b955e7df30c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "87d04b58-8700-479e-81c2-15c2292a4426",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "bb105dac-e493-4df9-b46f-ceec45354b28",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "597eb7dc-9d1a-4b7d-89c7-11decff15ce7",
                            RoleId = "68fd8a93-466b-4e68-bc7d-1b955e7df30c"
                        },
                        new
                        {
                            UserId = "b76032f3-96a3-4164-b534-84d784d361a3",
                            RoleId = "bb105dac-e493-4df9-b46f-ceec45354b28"
                        },
                        new
                        {
                            UserId = "73f7badf-20b3-4401-9585-4d407e8f71ac",
                            RoleId = "87d04b58-8700-479e-81c2-15c2292a4426"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("specchat.API.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PictureContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PictureData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "597eb7dc-9d1a-4b7d-89c7-11decff15ce7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6cfd1d4d-2cc9-48c0-99ac-be2fda69933b",
                            Email = "admin@admin.adm",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMINUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAELaVkvyYilZkXoylkv9F8qTU62zNd2Lggk2kmvkysixjCxNrRKReFQ2PONoa08CE2g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "60904ce4-eb50-4321-98fd-c212b5095004",
                            TwoFactorEnabled = false,
                            UserName = "adminuser"
                        },
                        new
                        {
                            Id = "b76032f3-96a3-4164-b534-84d784d361a3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e4c8dfe0-ded1-4b4c-b81a-01463777cda9",
                            Email = "teacher@teach.er",
                            EmailConfirmed = true,
                            FirstName = "Teacher",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedUserName = "TEACHEREX",
                            PasswordHash = "AQAAAAEAACcQAAAAEBT5eY5iNZ5kLaVncGs4I1taV5LkRtLz8CskPywXIns3JDNwlT9qObq2kLWtXV1pFw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9e5de061-e06d-4d49-94a9-12d1a38fb1b5",
                            TwoFactorEnabled = false,
                            UserName = "teacherex"
                        },
                        new
                        {
                            Id = "73f7badf-20b3-4401-9585-4d407e8f71ac",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "89bbc5c0-d90b-4894-802d-08f44f49d65b",
                            Email = "basic@us.er",
                            EmailConfirmed = true,
                            FirstName = "Basic",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedUserName = "BASICUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEP6xnbBUpOzHtVmTt33Du66PDa3Sem0h1r80tVfTYTPz7D6b8wJpiSSh3HlTCSjJqA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "07a9c20d-17af-4b8b-92ce-fb7fe7489e23",
                            TwoFactorEnabled = false,
                            UserName = "basicuser"
                        });
                });

            modelBuilder.Entity("specchat.API.Models.Chat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            Id = "ee3302b5-444c-4fc3-ba77-34ee40f5cc8a",
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = "856cb1b1-7b59-4782-b35c-4bb1344788fa",
                            Name = "Product Management"
                        },
                        new
                        {
                            Id = "28c07e65-9fb0-4900-9cd9-faa3f97704d9",
                            Name = "Support"
                        },
                        new
                        {
                            Id = "e2da4790-1523-410e-a47b-e8323ad4a4f6",
                            Name = "Product Management"
                        },
                        new
                        {
                            Id = "b8797f95-cc86-47bd-b4e3-4edd7a7dba24",
                            Name = "Training"
                        },
                        new
                        {
                            Id = "70f0f02d-83de-490b-b42d-e37fff244f77",
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = "a4e1ade6-03db-497e-b12b-467a5f4bc130",
                            Name = "Services"
                        },
                        new
                        {
                            Id = "76d422c9-6d26-42a4-a24b-aae84b4ad0ae",
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = "cc232931-57f3-4681-84fd-3d34c524f816",
                            Name = "Research and Development"
                        },
                        new
                        {
                            Id = "9ff197fe-35a1-450c-978e-2e0bd500668b",
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = "06529009-e3f0-48a3-a57a-86b61b71cf9f",
                            Name = "Játékok"
                        },
                        new
                        {
                            Id = "1b60c271-fb5e-4f5e-bc81-e9a5b5f1ad78",
                            Name = "Alamónium"
                        },
                        new
                        {
                            Id = "e4a93b77-7cb4-455f-b826-86bf3fbdf79e",
                            Name = "Beszélgető"
                        });
                });

            modelBuilder.Entity("specchat.API.Models.ChatUser", b =>
                {
                    b.Property<string>("ChatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ChatId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatUsers");
                });

            modelBuilder.Entity("specchat.API.Models.Emoji", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MessageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Emojis");
                });

            modelBuilder.Entity("specchat.API.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPinned")
                        .HasColumnType("bit");

                    b.Property<string>("MainMessageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("MainMessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("specchat.API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("specchat.API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("specchat.API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("specchat.API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("specchat.API.Models.ChatUser", b =>
                {
                    b.HasOne("specchat.API.Models.Chat", "Chat")
                        .WithMany("ChatUsers")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("specchat.API.Models.ApplicationUser", "User")
                        .WithMany("ChatUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("specchat.API.Models.Emoji", b =>
                {
                    b.HasOne("specchat.API.Models.Message", "Message")
                        .WithMany("Emojis")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("specchat.API.Models.ApplicationUser", "User")
                        .WithMany("Emojis")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("specchat.API.Models.Message", b =>
                {
                    b.HasOne("specchat.API.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("specchat.API.Models.Message", "MainMessage")
                        .WithMany("SubMessage")
                        .HasForeignKey("MainMessageId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("specchat.API.Models.ApplicationUser", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("MainMessage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("specchat.API.Models.ApplicationUser", b =>
                {
                    b.Navigation("ChatUsers");

                    b.Navigation("Emojis");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("specchat.API.Models.Chat", b =>
                {
                    b.Navigation("ChatUsers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("specchat.API.Models.Message", b =>
                {
                    b.Navigation("Emojis");

                    b.Navigation("SubMessage");
                });
#pragma warning restore 612, 618
        }
    }
}
