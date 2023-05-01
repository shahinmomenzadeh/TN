using ClassLibrary1;
using Microsoft.EntityFrameworkCore;

namespace DB;

public class DBdemoo : DbContext
{
    public DBdemoo(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Todo>Todos { get; set; }
    
}