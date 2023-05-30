using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using specchat.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace specchat.API.Models;

public class ApplicationUser : IdentityUser
{
    [Required, StringLength(200)]
    public string FirstName { get; set; }
    [Required, StringLength(200)]
    public string LastName { get; set; }

    public string? PictureContentType { get; set; }

    public byte[]? PictureData { get; set; }

    [NotMapped]
    [ForeignKey("UserId")]
    [JsonIgnore]
    public virtual ICollection<ChatUser> ChatUsers { get; set; }

    [JsonIgnore]
    [NotMapped]
    public virtual ICollection<Message> Messages { get; set; }

    [JsonIgnore]
    [NotMapped]
    public virtual ICollection<Emoji>? Emojis { get; set; }

    public ApplicationUser()
    {
        Id = Guid.NewGuid().ToString();
        ChatUsers = new HashSet<ChatUser>();
        Messages = new HashSet<Message>();
        Emojis = new HashSet<Emoji>();
    }

}

