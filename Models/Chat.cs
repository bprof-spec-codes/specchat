using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Chat
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Id { get; set; }
        public string Name { get; set; }

		[JsonIgnore]
		public virtual ICollection<ApplicationUser> Users { get; set; }

		[JsonIgnore]
		public virtual ICollection<Message> Messages { get; set; }
        public override string ToString()
        {
            return $"{Id}: {Name}";
        }

        public Chat()
        {
            Id = Guid.NewGuid().ToString();
            Messages = new HashSet<Message>();
            Users = new HashSet<ApplicationUser>();
        }

		public Chat(string name)
		{
			Id = Guid.NewGuid().ToString();
            Name = name;
		}
	}
}
