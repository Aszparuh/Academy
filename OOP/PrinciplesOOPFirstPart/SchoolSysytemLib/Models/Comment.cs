namespace SchoolSysytemLib.Models
{
    using System;

    public class Comment : IComparable
    {
        private string text;
        private DateTime dateCreated;

        public Comment(string text)
        {
            this.Text = text;
            this.dateCreated = DateTime.Now;
        }

        public string Text
        {
            get { return this.text; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The comment could not be null or empty");
                }

                this.text = value;
            }
        }

        public DateTime DateCreated
        {
            get { return this.dateCreated; }
            
        }

        public int CompareTo(object other)
        {
            if (other == null)
            {
                return 1;
            }

            Comment otherComment = other as Comment;
            if (otherComment != null)
            {
                return this.dateCreated.CompareTo(otherComment.dateCreated);
            }
            else
            {
                throw new ArgumentException("Object is not a Temperature");
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.dateCreated.ToString(), this.text);
        }
    }
}