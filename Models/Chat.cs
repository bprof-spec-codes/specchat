namespace specchat.Models
{
    public class Chat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        public override string ToString()
        {
            return $"{Id}: {Name}";
        }

        public Chat()
        {
            Id = Guid.NewGuid();
            Topics = new HashSet<Topic>();
            Users = new HashSet<ApplicationUser>();
        }
    }
}
