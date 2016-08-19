namespace Exceptions_Homework.Models
{
    using System;

    public class ExamResult
    {
        private int grade;

        private int minGrade;

        private int maxGrade;

        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                this.ValidateNumberIsPositive(value, nameof(this.Grade));

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                this.ValidateNumberIsPositive(value, nameof(this.MinGrade));

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.MaxGrade), $"Must be bigger than {this.MinGrade}.");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Comments cannot be null or empty.");
                }

                this.comments = value;
            }
        }

        private void ValidateNumberIsPositive(int number, string parameterName)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, "Cannot be negative.");
            }
        }
    }
}