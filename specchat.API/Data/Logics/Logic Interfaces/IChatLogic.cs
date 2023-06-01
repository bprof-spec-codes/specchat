using Microsoft.AspNetCore.Mvc;
using specchat.API.Models;

namespace specchat.API.Data.Logics.Logic_Interfaces
{
    public interface IChatLogic
    {
        IEnumerable<Chat> GetAll();
        Chat GetById(string id);
        IEnumerable<Chat> GetByUserId(string id);
        void AddNewChat([FromBody] Chat chat);
        void UpdateChat([FromBody] Chat chat);
        void DeleteChat(string id);
        void AddUserToChat(string chatId, string userId);
        bool IsUserInChat(string chatId, string userId);
        IEnumerable<ApplicationUser> GetByChatId(string chatId);
        void RemoveUserFromChat(string chatid, string userId);
    }
}
