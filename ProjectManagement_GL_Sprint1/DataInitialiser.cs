using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public static class DataInitialiser
    {

        public static void InitializeUsers(IServiceProvider serviceProvider)
        {
            using(var context=new ApiDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApiDbContext>>()))
            {
                if (context.Users.Any())
                {
                    return;
                }
                context.Users.AddRange(
                    new User() { Email = "kd@gmail.com", FirstName = "kd", LastName = "vyas", Password = "kd@123" },
                    new User() { Email = "mv@gmail.com", FirstName = "mohit", LastName = "vyas", Password = "mv@123" }
                    );
                context.SaveChanges();
            }
        }

        public static void InitializeProjects(IServiceProvider serviceProvider)
        {
            using (var context = new ApiDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApiDbContext>>()))
            {
                if (context.Projects.Any())
                {
                    return;
                }
                context.Projects.AddRange(
                     new Project()
                     {

                         Name = "ProjectA",
                         Detail = "This is Project A",
                         CreatedOn = DateTime.Now
                     },
                     new Project()
                     {
                         Name = "ProjectB",
                         Detail = "This is Project B",
                         CreatedOn = DateTime.Now
                     });
                context.SaveChanges();
            }
        }

        public static void InitializeTasks(IServiceProvider serviceProvider)
        {
            using (var context = new ApiDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApiDbContext>>()))
            {
                if (context.Tasks.Any())
                {
                    return;
                }
                context.Tasks.AddRange(
                     new Models.Task()
                     {
                         Status = 1,
                         AssignedToUserId = 1,
                         ProjectId = 1,
                         Detail = "Task 1",
                         CreatedOn = DateTime.Now
                     },
                     new Models.Task()
                     { 
                         Status = 1,
                         AssignedToUserId = 1,
                         ProjectId = 1,
                         Detail = "Task 2",
                         CreatedOn = DateTime.Now
                     });
                context.SaveChanges();
            }
        }
    }
}
