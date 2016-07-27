namespace SchoolSystem
{
    public static class IdGenerator
    {
        private const int IdMinValue = 10000;
        private static int id = IdMinValue;

        public static int GetNewId()
        {
            return id++;
        }

        public static void Restart()
        {
            id = IdMinValue;
        }
    }
}
