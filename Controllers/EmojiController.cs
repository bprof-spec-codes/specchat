using Microsoft.AspNetCore.Mvc;
using specchat.Data.Logics.Logic_Interfaces;
using specchat.Models;

namespace specchat.Controllers
{
    [Route("api/[controller]")]
    public class EmojiController : Controller
    {
        private readonly IEmojiLogic _emojiLogic;

        public EmojiController(IEmojiLogic emojiLogic)
        {
            _emojiLogic = emojiLogic;
        }

        [HttpPost]
        public void AddNewEmoji([FromBody] Emoji emoji)
        {
            try
            {
                _emojiLogic.AddNewEmoji(emoji);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }

        [HttpDelete("{id}")]
        public void DeleteEmoji(string id)
        {
            try
            {
                _emojiLogic.DeleteEmoji(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }

        [HttpGet]
        public IEnumerable<Emoji> GetAll()
        {
            return _emojiLogic.GetAll();
        }

        [HttpGet("{id}")]
        public Emoji GetById(string id)
        {
            try
            {
                return _emojiLogic.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
                throw;
            }
        }

        [HttpPut]
        public void UpdateEmoji([FromBody] Emoji emoji)
        {
            try
            {
                _emojiLogic.UpdateEmoji(emoji);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }
    }
}
