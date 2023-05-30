using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using specchat.API.Models;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace specchat.API.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Message> Messages { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Emoji> Emojis { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }

    public DbSet<ChatUser> ChatUsers { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ChatUser>()
            .HasKey(t => new { t.ChatId, t.UserId });

        builder.Entity<ChatUser>()
            .HasOne(t => t.Chat)
            .WithMany(t => t.ChatUsers)
            .HasForeignKey(t => t.ChatId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ApplicationUser>()
            .Ignore(c => c.ChatUsers);

        builder.Entity<ChatUser>()
            .HasOne(t => t.User)
            .WithMany(t => t.ChatUsers)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Message>()
            .HasOne(t => t.MainMessage)
            .WithMany(t => t.SubMessage)
            .HasForeignKey(t => t.MainMessageId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Message>()
            .HasOne(t => t.User)
            .WithMany(t => t.Messages)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Message>()
            .HasOne(t => t.Chat)
            .WithMany(t => t.Messages)
            .HasForeignKey(t => t.ChatId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Emoji>()
            .HasOne(t => t.User)
            .WithMany(t => t.Emojis)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Emoji>()
            .HasOne(t => t.Message)
            .WithMany(t => t.Emojis)
            .HasForeignKey(t => t.MessageId)
            .OnDelete(DeleteBehavior.NoAction);

        string adminRoleId = Guid.NewGuid().ToString();
        string teacherRoleId = Guid.NewGuid().ToString();
        string userRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(
                new { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = userRoleId, Name = "User", NormalizedName = "USER" },
                new { Id = teacherRoleId, Name = "Teacher", NormalizedName = "TEACHER"}
                );

        PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
        ApplicationUser adminuser = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "admin@admin.adm",
            EmailConfirmed = true,
            UserName = "adminuser",
            FirstName = "Super",
            LastName = "User",
            NormalizedUserName = "ADMINUSER"
        };

        ApplicationUser teacher = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "teacher@teach.er",
            EmailConfirmed = true,
            UserName = "teacherex",
            FirstName = "Teacher",
            LastName = "User",
            NormalizedUserName = "TEACHEREX"
        };

        ApplicationUser basicuser = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "basic@us.er",
            EmailConfirmed = true,
            UserName = "basicuser",
            FirstName = "Basic",
            LastName = "User",
            NormalizedUserName = "BASICUSER"
        };


        adminuser.PasswordHash = ph.HashPassword(adminuser, "Passw0rd");
        teacher.PasswordHash = ph.HashPassword(teacher, "Passw0rd");
        basicuser.PasswordHash = ph.HashPassword(basicuser, "Passw0rd");
        builder.Entity<ApplicationUser>().HasData(adminuser, teacher, basicuser);

        builder.Entity<IdentityUserRole<string>>().HasData(
            new { UserId = adminuser.Id, RoleId = adminRoleId },
            new { UserId = teacher.Id, RoleId = teacherRoleId },
            new { UserId = basicuser.Id, RoleId = userRoleId }
        );


        builder.Entity<Chat>()
            .HasData(JsonConvert.DeserializeObject<List<Chat>>(File.ReadAllText("Data/SeedData/gchats.json")));
        base.OnModelCreating(builder);
    }
}

