using DotNetSixMinimalApi.Models;

namespace DotNetSixMinimalApi.Data
{
    public interface ICommandRepo
    {
        Task SaveChanges();
        Task<Command?> GetCommandById(int id);
        Task<IEnumerable<Command>> GetAllCommands();
        Task CreateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}