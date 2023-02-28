using Angular.DbContexts;
using Angular.Models;

namespace Angular.Services
{
    public class UserService: IUserService
    {
        private readonly TaskManagmentAppContext _TaskManagmentAppContext;
        public UserService(TaskManagmentAppContext TaskManagmentAppContext)
        {
            _TaskManagmentAppContext = TaskManagmentAppContext;
        }
        public List<User> GetAllUsers()
        {
            return _TaskManagmentAppContext.User.ToList();
        }
    }
}
