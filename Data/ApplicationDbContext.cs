using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using specchat.Models;
using System.IO;
using Microsoft.AspNetCore.Identity;

namespace specchat.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
	public DbSet<Message> Messages { get; set; }
	public DbSet<Chat> Chats { get; set; }
	public DbSet<Emoji> Emojis { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }

	public DbSet<ChatUser> ChatUsers { get; set; }

    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
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


        PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
		List<ApplicationUser> users = new List<ApplicationUser>();

		ApplicationUser kovi = new ApplicationUser
		{
			Id = Guid.NewGuid().ToString(),
			Email = "user@gmail.com",
			EmailConfirmed = true,
			UserName = "user@gmail.com",
			NormalizedUserName = "USER@GMAIL.COM",
			FirstName = "Basic",
			LastName = "User"
		};

        ApplicationUser simpleUser = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "simple@gmail.com",
            EmailConfirmed = true,
            UserName = "simple@gmail.com",
            NormalizedUserName = "SIMPLE@GMAIL.COM",
            FirstName = "Simple",
            LastName = "User"
        };

        ApplicationUser teacher = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "teacher@gmail.com",
            EmailConfirmed = true,
            UserName = "teacher@gmail.com",
            NormalizedUserName = "TEACHER@GMAIL.COM",
            FirstName = "Teacher",
            LastName = "Teacher_last"
        };
        users.Add(kovi);
		users.Add(simpleUser);
		users.Add(teacher);

		List<IdentityRole> roles = new List<IdentityRole>();

		IdentityRole admin = (new IdentityRole()
        {
            Id = "1",
            Name = "admin",
        });

        IdentityRole simple = (new IdentityRole()
        {
            Id = "2",
            Name = "simple",
        });

        IdentityRole teacherRole = (new IdentityRole()
        {
            Id = "3",
            Name = "Teacher",
        });

        roles.Add(admin);
		roles.Add(simple);
		roles.Add(teacherRole);

        builder.Entity<IdentityRole>().HasData(roles);

        kovi.PasswordHash = ph.HashPassword(kovi, "password");
        simpleUser.PasswordHash = ph.HashPassword(simpleUser, "passw0rd");
        teacher.PasswordHash = ph.HashPassword(teacher, "teacherpass");

        builder.Entity<ApplicationUser>().HasData(users);

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
		{
			RoleId = "1",
			UserId = kovi.Id
		});

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
        {
            RoleId = "2",
            UserId = simpleUser.Id
        });

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
        {
            RoleId = "3",
            UserId = teacher.Id
        });

		List<Chat> chats = new List<Chat>();

		Chat c1 = new Chat()
		{
			Name = "Beszélgető"
		};
		chats.Add(c1);
		Chat c2 = new Chat()
		{
			Name = "Játékok"
		};
		chats.Add(c2);

        Chat c3 = new Chat()
        {
            Name = "Alamónium"
        };
        chats.Add(c3);
        builder.Entity<Chat>().HasData(chats);
		// DB migration elhasalt tőle 
		//builder.Entity<Emoji>().HasData(new Emoji[]
		//{
		//	new Emoji("U+1F600"),
		//	new Emoji("U+1F604"),
		//	new Emoji("U+1F970"),
		//	new Emoji("U+1F60D")
		//});
		List<Message> messages = new List<Message>();

		Message msg1 = new Message()
		{
			Content = "Elso uzenet",
			Time = DateTime.Now,
			UserId = kovi.Id,
			ChatId = c1.Id
		};
		messages.Add(msg1);

        Message msg2 = new Message()
        {
            Content = "Masodik Uzenet",
            Time = DateTime.Now,
            UserId = kovi.Id,
            ChatId = c2.Id
        };
		messages.Add(msg2);

		Message msg3 = new Message()
		{
			Content = "harmadik uzenet",
			Time = DateTime.Now,
			UserId = kovi.Id,
			ChatId = c3.Id
		};

		Message msg4 = new Message()
		{
			Content = "negyedik uzenet",
			Time = DateTime.Now,
			UserId = kovi.Id,
			ChatId = c2.Id,
			MainMessageId = msg3.Id
		};
		//msg3.SubMessage.Add(msg4);
		messages.Add(msg3);
		messages.Add(msg4);

		builder.Entity<Message>().HasData(messages);
		base.OnModelCreating(builder);
	}
}

