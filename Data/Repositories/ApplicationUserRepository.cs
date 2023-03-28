using specchat.Data.Repositories.Interfaces;
using specchat.Models;
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
			var usr = _context.Users.FirstOrDefault(t => t.Id == id); // Chat.Id (Guid) nem összehasonlítható id(string) -vel
			if (usr == null)
			{
				throw new ArgumentException("There's no User with this id: " + id);
			}

			_context.Users.Remove(usr);
			_context.SaveChanges();
		}

		public IEnumerable<ApplicationUser> Read()
		{
			return _context.Users;
		}

		public ApplicationUser Read(string id)
		{
			var user = _context.Users.FirstOrDefault(t => t.Id == id);
			if (user == null)
			{
				throw new ArgumentException("There's no User with this id: " + id);
			}
			return user;
		}

		public void Update(ApplicationUser user)
		{
			var old = _context.Users.FirstOrDefault(t => t.Id == user.Id);
			if (old == null)
			{
				throw new ArgumentException("There's no User with this id: " + user.Id);
			}
			old.Email = user.Email;
			old.FirstName = user.FirstName;
			old.LastName = user.LastName;
			_context.SaveChanges();
		}
	}
}
