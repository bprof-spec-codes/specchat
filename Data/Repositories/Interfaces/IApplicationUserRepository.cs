using specchat.Models;

namespace specchat.Data.Repositories.Interfaces
{
    public interface IApplicationUserRepository
    {
        void Create(ApplicationUser user);
        IEnumerable<ApplicationUser> Read();
        ApplicationUser Read(string id);
        void Update(ApplicationUser user);
        void Delete(string id);
    }
}
