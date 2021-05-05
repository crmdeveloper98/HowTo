using HowToAPI.Models;
using System.Collections.Generic;

namespace HowToAPI.Data
{
    public interface ICommandRepository
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandbyId(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
