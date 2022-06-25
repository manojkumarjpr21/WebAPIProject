using Microsoft.EntityFrameworkCore;
namespace WebAPIProject.models
{
    public class ToDoContext:DbContext 
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}