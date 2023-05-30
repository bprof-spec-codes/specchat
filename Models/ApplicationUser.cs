using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace specchat.Models;

public class ApplicationUser : IdentityUser
{
    public ApplicationUser()
    {
        Id = Guid.NewGuid().ToString();
        ChatUsers = new HashSet<ChatUser>();
        Messages = new HashSet<Message>();
        Emojis = new HashSet<Emoji>();
    }

    public string FirstName { get; set; }
	public string LastName { get; set; }

    public string? PictureContentType { get; set; }

    public byte[]? PictureData { get; set; }

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

