using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data.Core;
using Task = ProjectManagement.Models.Task;

namespace ProjectManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : BaseController<Task, TaskRepository>
    {
        public TaskController(TaskRepository repository) : base(repository)
        {

        }
    }
}