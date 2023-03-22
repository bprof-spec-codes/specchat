namespace specchat.Models
{
    public class Chat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public override string ToString()
        {
            return $"{Id}: {Name}";
        }

        public Chat()
        {
            Id = Guid.NewGuid();
            Messages = new HashSet<Message>();
            Users = new HashSet<ApplicationUser>();
        }
    }
}
