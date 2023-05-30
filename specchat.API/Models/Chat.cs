using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using specchat.API.Models;

namespace specchat.API.Models
{
    public class Chat
    {
        public Chat()
        {
            Id = Guid.NewGuid().ToString();
            Messages = new HashSet<Message>();
            ChatUsers = new HashSet<ChatUser>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<ChatUser> ChatUsers { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Message> Messages { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
