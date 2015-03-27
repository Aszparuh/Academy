namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;

    class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        { }

        public void AddDiscipline(Discipline newDisc)
        {
            this.disciplines.Add(newDisc);
        }

        public void RemoveDiscipline(int index)
        {
            if (index > -1 && index < this.disciplines.Count)
            {
                this.disciplines.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid discipline index");
            }
        }

        public List<Discipline> GetAllDisciplines()
        {
            if (this.disciplines.Count == 0)
            {
                throw new InvalidOperationException("There are no disciplines yet.");
            }

            return new List<Discipline>(this.disciplines);
        }
    }
}