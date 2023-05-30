using specchat.API.Data;
using specchat.API.Data.Repositories;
using specchat.API.Models;
using System;

namespace specchat.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(ApplicationUser user)
        {
            var old = _context.Users.FirstOrDefault(t => t.NormalizedEmail == user.NormalizedEmail); // ID vagy Név-re szűrjünk? 
            if (old != null)
            {
                throw new ArgumentException("There's already a User with this email: " + user.Email);
            }

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> Read()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Read(string id)
        {
            return _context.Users.FirstOrDefault(t => t.Id == id);
        }

        public void Update(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.Users;
        }
    }
}
