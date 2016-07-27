namespace Exceptions_Homework.Models
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MaxScore = 100;
        private const int MinSocre = 0;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score 
        { 
            get
            {
                return this.score;
            }
            
            private set
            {
                if (value < MinSocre || value > MaxScore)
                {
                    throw new ArgumentException("Score should be between 0 and 100");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MinSocre, MaxScore, "Exam results calculated by score.");
        }
    }
}