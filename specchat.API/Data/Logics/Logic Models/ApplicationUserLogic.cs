using Microsoft.AspNetCore.Mvc;
using specchat.API.Data.Logics;
using specchat.API.Models;
using specchat.API.Data.Repositories;
using specchat.API.Data.Logics.Logic_Interfaces;
using specchat.API.Data.Repositories.Repository_Intefaces;

namespace specchat.API.Data.Logics.Logic_Models
{
    public class ApplicationUserLogic : IApplicationUserLogic
    {
        IApplicationUserRepository rep;

        public ApplicationUserLogic(IApplicationUserRepository rep)
        {
            this.rep = rep;
        }

        public void AddNewUser([FromBody] ApplicationUser user)
        {
            rep.Create(user);
        }

        public void DeleteUser(string id)
        {
            if (rep.Read(id) != null)
            {
                rep.Delete(id);
            }
            throw new Exception("This ID is not valid, or couldn't be found!");
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return rep.Read();
        }

        public ApplicationUser GetById(string id)
        {
            return rep.Read(id);
        }

        public void UpdateUser([FromBody] ApplicationUser user)
        {
            rep.Update(user);
        }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            return rep.GetUsers();
        }
    }
}
