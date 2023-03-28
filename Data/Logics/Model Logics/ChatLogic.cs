using AutoMapper.Internal;
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
			rep.Create(chat);
		}

		public void DeleteChat(string id)
		{
			if (rep.Read(id) != null)
			{
				rep.Delete(id);
			}
			throw new Exception("This ID is not valid, or couldn't be found!");
		}

		public IEnumerable<Chat> GetAll()
		{
			return rep.Read();
		}

		public Chat GetById(string id)
		{
			return rep.Read(id);
		}

		public void UpdateChat([FromBody] Chat chat)
		{
			rep.Update(chat);
		}
		public IEnumerable<ApplicationUser> GetParticipants(string id)
		{
			return rep.Read(id).ChatUsers.Select(x => x.User);
		}
		public IEnumerable<Message> GetMessages(string id)
		{
			return rep.Read(id).Messages.Where(x => x.MainMessage == null);
		}
	}
}