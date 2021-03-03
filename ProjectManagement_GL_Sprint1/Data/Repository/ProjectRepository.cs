using System;
using ProjectManagement.Models;
using ProjectManagement.Data.Core;

namespace ProjectManagement.Data.Core
{
    public class ProjectRepository: BaseRepository<Project,ApiDbContext>
    {
        public ProjectRepository(ApiDbContext context) : base(context)
        {

        }
    }
}
