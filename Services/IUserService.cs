using Angular.DbContexts;
using Angular.Models;

namespace Angular.Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
