using specchat.API.Models;

namespace specchat.API.Data.Repositories
{
    public interface IApplicationUserRepository
    {
        void Create(ApplicationUser user);
        IEnumerable<ApplicationUser> Read();
        ApplicationUser Read(string id);
        void Update(ApplicationUser user);
        void Delete(string id);
        IEnumerable<ApplicationUser> GetUsers();
    }
}
