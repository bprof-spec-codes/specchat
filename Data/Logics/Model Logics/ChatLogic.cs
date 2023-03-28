using Microsoft.AspNetCore.Mvc;
using specchat.Data.Repositories;
using specchat.Models;

namespace specchat.Data.Logics.Model_Logics
{
	public class ChatLogic : IChatLogic
	{
		IChatRepository rep;

		public ChatLogic(IChatRepository rep)
		{
			this.rep = rep;
		}

		public void AddNewChat([FromBody] Chat chat)
		{
			throw new NotImplementedException();
		}

		public void DeleteChat(string id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Chat> GetAll()
		{
			throw new NotImplementedException();
		}

		public Chat GetById(string id)
		{
			throw new NotImplementedException();
		}

		public void UpdateChat([FromBody] Chat chat)
		{
			throw new NotImplementedException();
		}
	}
