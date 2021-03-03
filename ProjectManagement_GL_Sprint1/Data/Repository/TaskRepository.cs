using System;
using ProjectManagement.Models;
using ProjectManagement.Data.Core;

namespace ProjectManagement.Data.Core
{
    public class TaskRepository: BaseRepository<Task,ApiDbContext>
    {
        public TaskRepository(ApiDbContext context) : base(context)
        {

        }
    }
}
