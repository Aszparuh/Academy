using System;

namespace SchoolSystem.Logic
{
    public class Mark
    {
        private const float MinimalMark = 2;
        private const float MaximalMark = 6;
        private float value;

        public Mark(Subject subject, float value)
        {
            this.Subject = subject;
            this.Value = value;
        }

        public float Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value < MinimalMark || value > MaximalMark)
                {
                    throw new ArgumentException("Mark value must be between 2 and 6 incluseive");
                }

                this.value = value;
            }
        }

        public Subject Subject { get; set; }
    }
}
