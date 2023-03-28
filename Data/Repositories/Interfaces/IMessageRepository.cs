using specchat.Models;

namespace specchat.Data.Repositories.Interfaces
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
