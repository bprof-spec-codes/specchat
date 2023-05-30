using Microsoft.AspNetCore.Mvc;
using specchat.API.Data.Logics;
using specchat.API.Models;
using specchat.API.Data.Repositories;
using specchat.API.Data.Repositories.Repository_Intefaces;
using specchat.API.Data.Logics.Logic_Interfaces;

namespace specchat.API.Data.Logics.Logic_Models
{
    public class MessageLogic : IMessageLogic
    {
        IMessageRepository rep;

        public MessageLogic(IMessageRepository rep)
        {
            this.rep = rep;
        }

        public void AddNewMessage([FromBody] Message msg)
        {
            rep.Create(msg);
        }

        public void DeleteMessage(string id)
        {
            if (rep.Read(id) != null)
            {
                rep.Delete(id);
            }
            else
            {
                throw new Exception("This ID is not valid, or couldn't be found!");
            }
        }

        public IEnumerable<Message> GetAll()
        {
            return rep.Read();
        }

        public Message GetById(string id)
        {
            return rep.Read(id);
        }

        public void UpdateMessage([FromBody] Message msg)
        {
            rep.Update(msg);
        }
    }
}
