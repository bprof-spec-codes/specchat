using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace specchat.Models;

public class ApplicationUser : IdentityUser
{
	public string FirstName { get; set; }
	public string LastName { get; set; }

	[JsonIgnore]
	[NotMapped]
	public virtual ICollection<ChatUser> ChatUsers { get; set; }
	
	[JsonIgnore]
	[NotMapped]
	public virtual ICollection<Message> Messages { get; set; }

    [JsonIgnore]
    [NotMapped]
    public virtual ICollection<Emoji>? Emojis { get; set; }

}

