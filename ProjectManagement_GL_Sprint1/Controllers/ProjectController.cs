using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data.Core;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : BaseController<Project, ProjectRepository>
    {
        public ProjectController(ProjectRepository repository) : base(repository)
        {

        }
    }
}
