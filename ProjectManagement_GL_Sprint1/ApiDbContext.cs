﻿using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;

namespace ProjectManagement

{
    public class ApiDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
