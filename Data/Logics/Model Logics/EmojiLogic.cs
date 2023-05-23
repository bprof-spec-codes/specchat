using Microsoft.AspNetCore.Mvc;
using specchat.Data.Repositories;
using specchat.Data.Repositories.Interfaces;
using specchat.Models;

namespace specchat.Data.Logics.Model_Logics
{
    public class EmojiLogic : IEmojiLogic
    {
        IEmojiRepository rep;

        public EmojiLogic(IEmojiRepository rep)
        {
            this.rep = rep;
        }

        public void AddNewEmoji([FromBody] Emoji emoji)
        {
            rep.Create(emoji);
        }

        public void DeleteEmoji(string id)
        {
            if (rep.Read(id) != null)
            {
                rep.Delete(id);
            }
            throw new Exception("This ID is not valid, or couldn't be found!");
        }

        public IEnumerable<Emoji> GetAll()
        {
            return rep.Read();
        }

        public Emoji GetById(string id)
        {
            return rep.Read(id);
        }

        public void UpdateEmoji([FromBody] Emoji emoji)
        {
            rep.Update(emoji);
        }
    }
}
