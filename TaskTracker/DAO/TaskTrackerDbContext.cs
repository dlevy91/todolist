using TaskTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskTracker.DAO
{
    public class TaskTrackerDbContext : DbContext
    {
        public TaskTrackerDbContext(DbContextOptions<TaskTrackerDbContext> options)
            : base(options) { }

        public DbSet<UserTask> Tasks {get; set;}
    }
}