using Microsoft.EntityFrameworkCore;
using specchat.API.Data;
using specchat.API.Data.Repositories;
using specchat.API.Data.Repositories.Repository_Intefaces;
using specchat.API.Models;
using System;

namespace specchat.API.Data.Repositories.Repository_Models
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

            message.Id = Guid.NewGuid().ToString();
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
            var message = _context.Messages.FirstOrDefault(t => t.Id == id);
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
            var message = _context.Messages.FirstOrDefault(t => t.Id == id);
            if (message == null)
            {
                throw new ArgumentException("There's no message with this id: " + id);
            }
            return message;
        }

        public void Update(Message message)
        {
            var old = _context.Messages.FirstOrDefault(t => t.Id == message.Id);

            old.IsPinned = message.IsPinned;
            old.Content = message.Content;
            old.Emojis = message.Emojis;

            if (old == null)
            {
                throw new ArgumentException("There's no message with this id: " + message.Id);
            }

            _context.SaveChanges();
        }
    }
}
