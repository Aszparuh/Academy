namespace SchoolSystem
{
    using System;

    public class Student
    {
        private const int IdMaxValue = 99999;
        private int id;
        private string name;

        public Student(string name)
        {
            this.Name = name;
            this.Id = IdGenerator.GetNewId();
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
                    throw new ArgumentException("Name cannot be empty or null");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set 
            {
                if (value > IdMaxValue)
                {
                    throw new InvalidOperationException("Maximum students reached");
                }

                this.id = value;
            }
        }
    }
}