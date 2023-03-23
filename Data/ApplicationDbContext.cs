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

    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
        
    }

	protected override void OnModelCreating(ModelBuilder builder)
	{
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

		
		builder.Entity<Chat>().HasData(new Chat[]
		{
			new Chat("Beszélgető"),
			new Chat("Kibeszélő"),
			new Chat("Játékok")
		});
		builder.Entity<Emoji>().HasData(new Emoji[]
		{
			new Emoji("U+1F600"),
			new Emoji("U+1F604"),
			new Emoji("U+1F970"),
			new Emoji("U+1F60D")
		});
		builder.Entity<Message>().HasData(new Message[]
		{
			new Message("Elso uzenet", DateTime.Now)
		});
		base.OnModelCreating(builder);
	}
}

