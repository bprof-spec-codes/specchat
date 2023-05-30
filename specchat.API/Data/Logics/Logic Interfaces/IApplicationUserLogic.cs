using Microsoft.AspNetCore.Mvc;
using specchat.API.Models;

namespace specchat.API.Data.Logics
{
    public interface IApplicationUserLogic
    {
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(string id);
        void AddNewUser([FromBody] ApplicationUser user);
        void UpdateUser([FromBody] ApplicationUser user);
        void DeleteUser(string id);
        IEnumerable<ApplicationUser> GetUsers();
    }
}