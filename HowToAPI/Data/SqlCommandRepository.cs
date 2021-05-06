using HowToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowToAPI.Data
{
    public class SqlCommandRepository : ICommandRepository
    {
        private readonly CommandDbContext _context;

        public SqlCommandRepository(CommandDbContext context) => _context = context;

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandbyId(int id)
        {
            return _context.CommandItems.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
