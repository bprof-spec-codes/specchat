using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace specchat.Models
{
    public class Emoji
    {
		public Emoji(string code)
		{
			code = code;
		}
		[Required]
		public string code { get; }

		[JsonIgnore]
		public ApplicationUser User { get; set; }

		[JsonIgnore]
		public Message Message { get; set; }
    }
}
