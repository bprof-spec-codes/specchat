using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Emoji
    {
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


        public Emoji()
        {
            Id = Guid.NewGuid().ToString();
        }
   //     public Emoji(string code)
   //     {
			//Id = Guid.NewGuid().ToString();
   //         Code = code;
   //     }
    }
}
