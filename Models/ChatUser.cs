using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace specchat.Models
{
    public class ChatUser
    {
        public ChatUser()
        {
            ChatId = Guid.NewGuid().ToString();
        }

        public string ChatId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Chat Chat { get; set; }

        public string UserId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ApplicationUser User { get; set; }
    }
}
