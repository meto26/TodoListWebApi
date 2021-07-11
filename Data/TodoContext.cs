using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace ToDoApi.Data
{
    public class TodoContext:DbContext
    {
    
    public  TodoContext(DbContextOptions<TodoContext>options) 
    : base(options)
    {

    }    
    public DbSet<TodoItem> TodoItems{get;set;}
    }
    
}