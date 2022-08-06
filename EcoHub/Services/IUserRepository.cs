using EcoHub.Models;

namespace EcoHub.Services
{
    public interface IUserRepository : IRepository<User>
    {
        void Update(User obj);
    }
}
