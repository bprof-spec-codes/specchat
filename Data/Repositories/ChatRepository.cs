using specchat.Models;
using System;
using System.Security.Cryptography;

namespace specchat.Data.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly ApplicationDbContext _context;

        public ChatRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Chat chat)
        {
            var old = _context.Chats.FirstOrDefault(t => t.Name == chat.Name); // ID vagy Név-re szűrjünk? 
            if (old != null)
            {
                throw new ArgumentException("There's already a chat with this name: " + chat.Name);
            }

            _context.Chats.Add(chat);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var chat = _context.Chats.FirstOrDefault(t => t.Id == id); // Chat.Id (Guid) nem összehasonlítható id(string) -vel
            if (chat == null)
            {
                throw new ArgumentException("There's no chat with this id: " + id);
            }

            _context.Chats.Remove(chat);
            _context.SaveChanges();
        }

        public IEnumerable<Chat> Read()
        {
            return _context.Chats;
        }

        public Chat Read(string id)
        {
            var chat = _context.Chats.FirstOrDefault(t => t.Id == id);
            if (chat == null)
            {
                throw new ArgumentException("There's no chat with this id: " + id);
            }
            return chat;
        }

        public void Update(Chat chat)
        {
            var old = _context.Chats.FirstOrDefault(t => t.Id == chat.Id);
            if (old == null)
            {
                throw new ArgumentException("There's no chat with this id: " + chat.Id);
            }
            old.Name = chat.Name;
            old.Messages = chat.Messages;
            old.ChatUsers = chat.ChatUsers;
            _context.SaveChanges();
        }
    }
}
