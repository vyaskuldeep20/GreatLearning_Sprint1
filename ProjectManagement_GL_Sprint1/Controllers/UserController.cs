using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data.Core;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User, UserRepository>
    {
        public UserController(UserRepository repository) : base(repository)
        {

        }
    }
}