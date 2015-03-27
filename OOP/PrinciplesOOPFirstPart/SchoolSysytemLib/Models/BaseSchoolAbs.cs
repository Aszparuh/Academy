namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class BaseSchoolAbs
    {
        private string name;
        private List<Comment> comments = new List<Comment>();

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

        public void AddComment(Comment newComment)
        {
            this.comments.Add(newComment);
        }

        public void RemoveComment(int index)
        {
            if (index > -1 && index < this.comments.Count)
            {
                this.comments.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid commet index");
            }
        }

        public List<Comment> GetAllComments()
        {
            return new List<Comment>(this.comments);
        }
    }
}