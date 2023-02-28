using Angular.Models;
using Angular.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _IUserService;
        public UserController(IUserService iUserService)
        {
            _IUserService = iUserService;
        }

        [Route("GetAllTask")]
        [HttpGet]
        public List<User> GetAllTask()
        {
            return _IUserService.GetAllUsers();
        }
    }
}
