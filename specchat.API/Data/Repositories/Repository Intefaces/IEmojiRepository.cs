using specchat.API.Models;

namespace specchat.API.Data.Repositories.Repository_Intefaces
{
    public interface IEmojiRepository
    {
        void Create(Emoji emoji);
        void Delete(string id);
        IEnumerable<Emoji> Read();
        Emoji Read(string id);
        void Update(Emoji emoji);
    }
}
