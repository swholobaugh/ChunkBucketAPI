using Microsoft.EntityFrameworkCore;
using Backend.Data.Models;

namespace Backend.Data
{
    public class BackendDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
        
        public BackendDbContext(DbContextOptions<BackendDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoList>().HasKey(x => new { x.TodoId, x.UserId });
        }
    }
}
