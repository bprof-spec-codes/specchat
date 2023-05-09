using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Message
    {
        public Message()
        {
            Id = Guid.NewGuid().ToString();
            SubMessage = new HashSet<Message>();
        }
        [Key]
        public string Id { get; set; }

		[Required]
		public string Content { get; set; }

        public DateTime Time { get; set; }

        public bool IsPinned { get; set; }

        public string UserId { get; set; }

		[JsonIgnore]
        [NotMapped]
		public virtual ApplicationUser User { get; set; }

        public string ChatId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Chat Chat { get; set; }


        public string? MainMessageId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Message? MainMessage { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Message>? SubMessage { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Emoji>? Emojis { get; set; }




        public override string ToString()
        {
            return $"{User.UserName}: {Content} at {Time}";
        }


		//public Message(string content, DateTime time)
		//{
  //          Id = Guid.NewGuid().ToString();
		//	Content = content;
		//	Time = time;
		//}
	}
}
