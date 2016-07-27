namespace SchoolSystem
{
    using System;
    using System.Threading;

    public class Student
    {
        private const int SutdentIdMinValue = 10000;
        private const int StudentIdMaxValue = 99999;

        private static int autoIncrementCounterForId = 10000;
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.Id = this.GetNextId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                if (value < SutdentIdMinValue || value > StudentIdMaxValue)
                {
                    throw new ArgumentOutOfRangeException($"Id must be between {SutdentIdMinValue} and {StudentIdMaxValue}");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        private int GetNextId()
        {
            return Interlocked.Increment(ref autoIncrementCounterForId);
        }
    }
}
