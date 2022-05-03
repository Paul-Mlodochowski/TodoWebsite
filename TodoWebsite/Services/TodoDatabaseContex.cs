using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TodoWebsite.Data;

namespace TodoWebsite.Services
{
    public class TodoDatabaseContex : DbContext
    {
        DbSet<TodoList> TodoLists { get; set; }
        DbSet<Tag> Tags { get; set; }

        public TodoDatabaseContex() {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=Database/TodoDb.db"); 
            base.OnConfiguring(optionsBuilder);
        }
    }
}
