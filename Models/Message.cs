namespace specchat.Models
{
    public class Message
    {
        public Guid Id { get; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public ApplicationUser User { get; set; }
        public Message MainThread { get; set; }
        public override string ToString()
        {
            return $"{User.UserName}: {Content} at {Time}";
        }
        public Message()
        {
            Id = Guid.NewGuid();
        }
    }
}
