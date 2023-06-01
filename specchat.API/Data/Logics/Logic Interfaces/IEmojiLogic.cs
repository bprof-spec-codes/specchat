using Microsoft.AspNetCore.Mvc;
using specchat.API.Models;

namespace specchat.API.Data.Logics.Logic_Interfaces
{
    public interface IEmojiLogic
    {
        void AddNewEmoji([FromBody] Emoji emoji);
        void DeleteEmoji(string id);
        IEnumerable<Emoji> GetAll();
        IEnumerable<Emoji> GetById(string id);
        void UpdateEmoji([FromBody] Emoji emoji);
    }
}
