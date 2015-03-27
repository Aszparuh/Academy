namespace SchoolSysytemLib.Models
{
    using System;

    class Discipline : BaseSchoolAbs
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int lectures, int exercises) : base(name)
        {
            this.NumberLectures = lectures;
            this.NumberExercises = numberOfExercises;
        }

        public int NumberLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lectures should be posstive number.");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of Exercises cannot be negative.");
                }

                this.numberOfExercises = value;
            }
        }
    }
}