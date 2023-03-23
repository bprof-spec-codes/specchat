using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; }

		[Required]
		public string Content { get; set; }
        public DateTime Time { get; set; }

		[JsonIgnore]
		public virtual ApplicationUser User { get; set; }
        public Message? MainThread { get; set; }
        public override string ToString()
        {
            return $"{User.UserName}: {Content} at {Time}";
        }
        public Message()
        {
            Id = Guid.NewGuid().ToString();
        }

		public Message(string content, DateTime time)
		{
            Id = Guid.NewGuid().ToString();
			Content = content;
			Time = time;
		}
	}
}
