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
			throw new NotImplementedException();
		}

		public void DeleteMessage(string id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Message> GetAll()
		{
			throw new NotImplementedException();
		}

		public Message GetById(string id)
		{
			throw new NotImplementedException();
		}

		public void UpdateMessage([FromBody] Message msg)
		{
			throw new NotImplementedException();
		}
	}
}
