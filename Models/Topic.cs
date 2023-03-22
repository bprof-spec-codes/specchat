namespace specchat.Models
{
    public class Topic
    {
        public Guid Id { get; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public ApplicationUser User { get; set; }
        public Topic MainThread { get; set; }
        public override string ToString()
        {
            return $"{User.UserName}: {Content} at {Time}";
        }
        public Topic()
        {
            Id = Guid.NewGuid();
        }

    }
}
