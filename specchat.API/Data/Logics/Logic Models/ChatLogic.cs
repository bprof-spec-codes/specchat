//using AutoMapper.Internal;
using Microsoft.AspNetCore.Mvc;
using specchat.API.Data.Logics;
using specchat.API.Models;
using specchat.API.Data.Repositories;
using specchat.API.Data.Repositories.Repository_Intefaces;
using specchat.API.Data.Logics.Logic_Interfaces;

namespace specchat.API.Data.Logics.Logic_Models
{
    public class ChatLogic : IChatLogic
    {
        IChatRepository rep;

        public ChatLogic(IChatRepository rep)
        {
            this.rep = rep;
        }

        public void AddNewChat([FromBody] Chat chat)
        {
            rep.Create(chat);
        }

        public void DeleteChat(string id)
        {
            if (rep.Read(id) != null)
            {
                rep.Delete(id);
            }
            throw new Exception("This ID is not valid, or couldn't be found!");
        }

        public IEnumerable<Chat> GetAll()
        {
            return rep.Read();
        }

        public Chat GetById(string id)
        {
            return rep.Read(id);
        }

        public IEnumerable<Chat> GetByUserId(string userid)
        {
            return rep.GetByUserId(userid);
        }


        public void UpdateChat([FromBody] Chat chat)
        {
            rep.Update(chat);
        }

        public void AddUserToChat(string chatId, string userId)
        {
            rep.AddUserToChat(chatId, userId);
        }

        public void RemoveUserFromChat(string chatid, string userId)
        {
            rep.RemoveUserFromChat(chatid, userId);
        }

        public bool IsUserInChat(string chatId, string userId)
        {
            return rep.IsUserInChat(chatId, userId);
        }

        public IEnumerable<ApplicationUser> GetByChatId(string chatId)
        {
            return rep.GetByChatId(chatId);
        }
    }
}