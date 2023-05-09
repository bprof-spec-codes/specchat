using Microsoft.EntityFrameworkCore;
using specchat.Data.Repositories.Interfaces;
using specchat.Models;
using System;

namespace specchat.Data.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Message message)
        {
            var old = _context.Messages.FirstOrDefault(t => t.Id == message.Id);
            if (old != null)
            {
                throw new ArgumentException("There's already a message with this id: " + message.Id);
            }

            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var message = _context.Messages.FirstOrDefault(t => t.Id == id); // Message.Id (Guid) nem összehasonlítható id(string) -vel
            if (message == null)
            {
                throw new ArgumentException("There's no message with this id: " + id);
            }

            _context.Messages.Remove(message);
            _context.SaveChanges();
        }

        public IEnumerable<Message> Read()
        {
            return _context.Messages;
        }

        public Message Read(string id)
        {
            var message = _context.Messages.FirstOrDefault(t => t.Id.ToString() == id);
            if (message == null)
            {
                throw new ArgumentException("There's no message with this id: " + id);
            }
            return message;
        }

        public void Update(Message message)
        {
            var old = _context.Messages.FirstOrDefault(t => t.Id == message.Id);
            if (old == null)
            {
                throw new ArgumentException("There's no message with this id: " + message.Id);
            }
        }
    }
}
