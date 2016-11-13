using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Commands.Contracts;

namespace SchoolSystem.Framework.Core.Factories
{
    public interface ICommandFactory
    {
        ICommand GetCommand(string commandName);
    }
}
