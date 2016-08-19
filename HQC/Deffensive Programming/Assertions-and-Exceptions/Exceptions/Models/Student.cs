namespace Exceptions_Homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private IList<Exam> exams;

        private string firstName;

        private string lastName;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateName(value, nameof(this.FirstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.ValidateName(value, nameof(this.LastName));

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null)
                {
                    value = new List<Exam>();
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> GetExamsResults()
        {
            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("There are no exams to check for this student.");
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int currentExam = 0; currentExam < this.Exams.Count; currentExam++)
            {
                results.Add(this.Exams[currentExam].Check());
            }

            return results;
        }

        public double CalculateAverageExamResultInPercents()
        {
            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("The student doesn't have any exams yet.");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.GetExamsResults();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade)
                               / (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }

        private void ValidateName(string name, string paramName)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException($"{paramName} cannot be null or empty.");
            }
        }
    }
}