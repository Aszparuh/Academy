namespace Animals.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Animals.Interfaces;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Gender gender;

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name canot be null or empty.");
                }

                this.name = value;
            }
        }

        public Gender Gender 
        {
            get { return this.gender; }
            set
            {
                this.gender = value;
            }
        }

        public virtual string MakeSound()
        {
            return "Muuuuu";
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Gender: {2}, Sound: {3}", this.Name, this.Age, this.Gender, this.MakeSound());
        }

        public static double AverageAge(IEnumerable<Animal> list)
        {
            return list.Average(an => an.Age);
        }
    }
}