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
			.HasForeignKey(t => t.ChatId);

		builder.Entity<ChatUser>()
			.HasOne(t => t.User)
			.WithMany(t => t.ChatUsers)
			.HasForeignKey(t => t.UserId);

        builder.Entity<Message>()
			.HasOne(t => t.MainMessage)
			.WithMany(t => t.SubMessage)
			.HasForeignKey(t => t.MainMessageId);

		builder.Entity<Message>()
			.HasOne(t => t.User)
			.WithMany(t => t.Messages)
			.HasForeignKey(t => t.UserId);

        builder.Entity<Message>()
            .HasOne(t => t.Chat)
            .WithMany(t => t.Messages)
            .HasForeignKey(t => t.ChatId);

		builder.Entity<Emoji>()
			.HasOne(t => t.User)
			.WithMany(t => t.Emojis)
			.HasForeignKey(t => t.UserId);

		builder.Entity<Emoji>()
			.HasOne(t => t.Message)
			.WithMany(t => t.Emojis)
			.HasForeignKey(t => t.MessageId);


        PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
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

		builder.Entity<IdentityRole>().HasData(new IdentityRole()
		{
			Id = "1",
			Name = "admin",
		});

		builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
		{
			RoleId = "1",
			UserId = kovi.Id
		});

		kovi.PasswordHash = ph.HashPassword(kovi, "password");
		builder.Entity<ApplicationUser>().HasData(kovi);

		Chat c1 = new Chat()
		{
			Name = "Beszélgető"
		};
		Chat c2 = new Chat()
		{
			Name = "Játékok"
		};
		builder.Entity<Chat>().HasData(c1 ,c2);
		// DB migration elhasalt tőle 
		//builder.Entity<Emoji>().HasData(new Emoji[]
		//{
		//	new Emoji("U+1F600"),
		//	new Emoji("U+1F604"),
		//	new Emoji("U+1F970"),
		//	new Emoji("U+1F60D")
		//});
		Message msg1 = new Message()
		{
			Content = "Elso uzenet",
			Time = DateTime.Now,
			UserId = kovi.Id,
			ChatId = c1.Id
		};
		builder.Entity<Message>().HasData(msg1);
		base.OnModelCreating(builder);
	}
}

