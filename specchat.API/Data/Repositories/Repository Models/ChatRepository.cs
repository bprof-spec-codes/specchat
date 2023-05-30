using Microsoft.EntityFrameworkCore;
using specchat.API.Data;
using specchat.API.Data.Repositories;
using specchat.API.Models;
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
            var old = _context.Chats.FirstOrDefault(t => t.Name == chat.Name);
            if (old != null)
            {
                throw new ArgumentException("There's already a chat with this name: " + chat.Name);
            }

            var newc = new Chat();
            newc.Name = chat.Name;

            _context.Chats.Add(newc);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var chat = _context.Chats.FirstOrDefault(t => t.Id == id);
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

        public bool IsUserInChat(string chatId, string userId)
        {
            return _context.ChatUsers.Any(cu => cu.ChatId == chatId && cu.UserId == userId);
        }

        public void AddUserToChat(string chatId, string userId)
        {
            var chat = _context.Chats.FirstOrDefault(t => t.Id == chatId);
            var user = _context.Users.FirstOrDefault(t => t.Id == userId);
            var isit = IsUserInChat(chatId, userId);


            if (chat != null && user != null && !isit)
            {
                var chatUser = new ChatUser
                {
                    ChatId = chat.Id,
                    UserId = user.Id
                };

                chat.ChatUsers.Add(chatUser);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Chat> GetByUserId(string userid)
        {
            var chats = _context.Chats
                .Where(chat => chat.ChatUsers.Any(chatUser => chatUser.UserId == userid))
                .ToList();

            return chats;
        }
    }
}
