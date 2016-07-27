namespace Exceptions_Homework.Models
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int PoorResult = 2;
        private const int AverageResult = 5;
        private const int MinProblems = 0;
        private const int MaxProblems = 10;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved 
        {
            get
            {
                return this.problemsSolved;
            }
            
            private set
            {
                if (value < MinProblems || value > MaxProblems)
                {
                    throw new ArgumentException("Problems must be between 10 and 0");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            string comment = string.Empty;

            if (this.ProblemsSolved <= PoorResult)
            {
                comment = "Poor result";
            }
            else if (this.ProblemsSolved <= AverageResult)
            {
                comment = "Average result";
            }
            else if (this.ProblemsSolved > AverageResult)
            {
                comment = "Exelent result";
            }

            return new ExamResult(this.ProblemsSolved, MinProblems, MaxProblems, comment);
        }
    }
}