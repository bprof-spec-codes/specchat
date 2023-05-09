using Microsoft.AspNetCore.Mvc;
using specchat.Models;

namespace specchat.Data.Logics.Model_Logics
{
	public interface IApplicationUserLogic
	{
		public IEnumerable<ApplicationUser> GetAll();
		public ApplicationUser GetById(string id);
		public void AddNewUser([FromBody] ApplicationUser user);
		public void UpdateUser([FromBody] ApplicationUser user);
		public void DeleteUser(string id);
	}
}