using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; }

		[Required]
		public string Content { get; set; }
        public DateTime Time { get; set; }

		[JsonIgnore]
		public virtual ApplicationUser User { get; set; }
        public Message MainThread { get; set; }
        public override string ToString()
        {
            return $"{User.UserName}: {Content} at {Time}";
        }
        public Message()
        {
            Id = Guid.NewGuid();
        }

		public Message(Guid id, string content, DateTime time)
		{
			Id = id;
			Content = content;
			Time = time;
		}
	}
}
