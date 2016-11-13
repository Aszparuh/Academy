using SchoolSystem.Framework.Core.Contracts;

namespace SchoolSystem.Framework.Core.Providers
{
    public class TeacherIdCreator : ITeacherIdProvider
    {
        private int nextId = 0;

        public int GetNextId()
        {
            return nextId++;
        }
    }
}
