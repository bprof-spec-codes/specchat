using Microsoft.AspNetCore.Mvc;
using specchat.Data.Logics.Logic_Interfaces;
using specchat.Data.Repositories;
using specchat.Models;

namespace specchat.Data.Logics.Model_Logics
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
			throw new Exception("This ID is not valid, or couldn't be found!");
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
