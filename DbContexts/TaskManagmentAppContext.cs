using Angular.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Angular.DbContexts
{
    public class TaskManagmentAppContext:DbContext
    {
        private readonly DbContextOptions<TaskManagmentAppContext> _options;

        public TaskManagmentAppContext(DbContextOptions<TaskManagmentAppContext> options)
            : base(options)
        {
            _options = options;
        }
        public DbSet<User> User { get; set; }
    }
}
