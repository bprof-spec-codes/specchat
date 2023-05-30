using Microsoft.AspNetCore.Mvc;
using specchat.API.Models;

namespace specchat.API.Data.Logics.Logic_Interfaces
{
    public interface IMessageLogic
    {
        public IEnumerable<Message> GetAll();
        public Message GetById(string id);
        public void AddNewMessage([FromBody] Message msg);
        public void UpdateMessage([FromBody] Message msg);
        public void DeleteMessage(string id);
    }
}
