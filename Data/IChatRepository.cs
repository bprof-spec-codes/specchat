using specchat.Models;

namespace specchat.Data
{
    public interface IChatRepository
    {
        void Create(Chat chat);
        IEnumerable<Chat> Read();
        Chat Read(string id);
        void Update(Chat chat);
        void Delete(string id);

    }
}
