using specchat.API.Data.Repositories.Repository_Intefaces;
using specchat.API.Models;

namespace specchat.API.Data.Repositories.Repository_Models
{
    public class EmojiRepository : IEmojiRepository
    {
        private readonly ApplicationDbContext _context;

        public EmojiRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Emoji emoji)
        {
            var old = _context.Emojis.FirstOrDefault(t => t.Id == emoji.Id);
            if (old != null)
            {
                throw new ArgumentException("There's already a emoji with this id: " + emoji.Id);
            }

            _context.Emojis.Add(emoji);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var emoji = _context.Emojis.FirstOrDefault(t => t.Id == id); // Emoji.Id (Guid) nem összehasonlítható id(string) -vel
            if (emoji == null)
            {
                throw new ArgumentException("There's no emoji with this id: " + id);
            }

            _context.Emojis.Remove(emoji);
            _context.SaveChanges();
        }

        public IEnumerable<Emoji> Read()
        {
            return _context.Emojis;
        }

        public Emoji Read(string id)
        {
            var emoji = _context.Emojis.FirstOrDefault(t => t.Id.ToString() == id);
            if (emoji == null)
            {
                throw new ArgumentException("There's no emoji with this id: " + id);
            }
            return emoji;
        }

        public void Update(Emoji emoji)
        {
            var old = _context.Emojis.FirstOrDefault(t => t.Id == emoji.Id);
            if (old == null)
            {
                throw new ArgumentException("There's no emoji with this id: " + emoji.Id);
            }
        }
    }
}
