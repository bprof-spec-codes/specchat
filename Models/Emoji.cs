using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Emoji
    {
        public Emoji()
        {
            Id = Guid.NewGuid().ToString();
        }

		[Key]
		public string Id { get; set; }

		[Required]
		public string Code { get; }

		public string UserId { get; set; }

		[JsonIgnore]
		[NotMapped]
		public virtual ApplicationUser User { get; set; }

		public string MessageId { get; set; }

		[JsonIgnore]
		[NotMapped]
		public virtual Message Message { get; set; }

    }
}
