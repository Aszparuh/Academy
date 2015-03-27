namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class BaseSchoolAbs
    {
        private string name;
        private List<string> comments = new List<string>();

        protected BaseSchoolAbs(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public abstract void AddComment(string comment);

        public abstract void RemoveComment(int number);
    }
}