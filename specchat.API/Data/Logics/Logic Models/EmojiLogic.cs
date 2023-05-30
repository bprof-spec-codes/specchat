using Microsoft.AspNetCore.Mvc;
using specchat.API.Data.Logics.Logic_Interfaces;
using specchat.API.Data.Repositories.Repository_Intefaces;
using specchat.API.Models;

namespace specchat.API.Data.Logics.Logic_Models
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
