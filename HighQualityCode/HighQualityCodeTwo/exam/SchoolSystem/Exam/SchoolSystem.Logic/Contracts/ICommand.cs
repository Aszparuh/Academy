using System.Collections.Generic;

namespace SchoolSystem.Logic.Contracts
{
    internal interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
