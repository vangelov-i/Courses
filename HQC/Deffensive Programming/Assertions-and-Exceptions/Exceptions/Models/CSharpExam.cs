namespace Exceptions_Homework.Models
{
    using System;

    public class CSharpExam : Exam
    {
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

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Score), "Cannot be negative or bigger than 100.");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            var result = new ExamResult(this.Score, 0, 100, "C# exam results calculated by score.");

            return result;
        }
    }
}