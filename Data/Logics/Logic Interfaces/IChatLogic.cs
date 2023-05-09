using Microsoft.AspNetCore.Mvc;
using specchat.Models;

namespace specchat.Data.Logics
{
	public interface IChatLogic
	{
		public IEnumerable<Chat> GetAll();
		public Chat GetById(string id);
		public void AddNewChat([FromBody] Chat chat);
		public void UpdateChat([FromBody] Chat chat);
		public void DeleteChat(string id);
	}
}
