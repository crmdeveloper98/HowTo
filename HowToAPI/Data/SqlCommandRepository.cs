using HowToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HowToAPI.Data
{
    public class SqlCommandRepository : ICommandRepository
    {
        private readonly CommandDbContext _context;

        public SqlCommandRepository(CommandDbContext context) => _context = context;

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.CommandItems.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.CommandItems.Remove(cmd);
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
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            // We don't need to do anything here!
        }
    }
}
