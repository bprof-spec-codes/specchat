using specchat.API.Models;

namespace specchat.API.Data.Repositories.Repository_Intefaces
{
    public interface IMessageRepository
    {
        void Create(Message message);
        IEnumerable<Message> Read();
        Message Read(string id);
        void Update(Message message);
        void Delete(string id);

    }
}
