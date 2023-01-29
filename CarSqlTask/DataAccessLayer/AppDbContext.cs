using CarSqlTask.Models;
using Microsoft.EntityFrameworkCore;


namespace CarSqlTask.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options ):base(options){ }

        public DbSet<Group> Groups { get; set; }
    }
}
