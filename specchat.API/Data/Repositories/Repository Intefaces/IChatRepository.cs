using specchat.API.Models;

namespace specchat.API.Data.Repositories.Repository_Intefaces
{
    public interface IChatRepository
    {
        void Create(Chat chat);
        IEnumerable<Chat> Read();
        Chat Read(string id);
        void Update(Chat chat);
        void Delete(string id);
        bool IsUserInChat(string chatId, string userId);
        void AddUserToChat(string chatId, string userId);
        IEnumerable<Chat> GetByUserId(string userid);
    }
}
