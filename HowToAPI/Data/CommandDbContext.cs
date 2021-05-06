using HowToAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HowToAPI.Data
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options) { }

        public DbSet<Command> CommandItems {get; set;}
    }
}
