using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Chat
    {
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

        public Chat()
        {
            Id = Guid.NewGuid().ToString();
            Messages = new HashSet<Message>();
            ChatUsers = new HashSet<ChatUser>();
        }

		//public Chat(string name)
		//{
		//	Id = Guid.NewGuid().ToString();
  //          Name = name;
  //      }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
}
}
