using SchoolSystem.Framework.Core.Contracts;

namespace SchoolSystem.Framework.Core.Providers
{
    public class StudentIdCreator : IStudentIdProvider
    {
        private int nextId = 0;
         
        public int GetNextId()
        {
            return nextId++;
        }
    }
}
