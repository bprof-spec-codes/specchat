namespace specchat.Models
{
    public class Emojis
    {
        public string Code { get; }
        public ApplicationUser User { get; set; }
        public Message Message { get; set; }
    }
}
