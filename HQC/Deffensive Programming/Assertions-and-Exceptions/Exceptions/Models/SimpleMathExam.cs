using System;

using Exceptions_Homework.Models;

public class SimpleMathExam : Exam
{
    private const int MaxProblemSolved = 2;

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
            if (value < 0 || value > MaxProblemSolved)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(this.ProblemsSolved), 
                    $"Cannot be negative or bigger than {MaxProblemSolved}.");
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        ExamResult result;
        switch (this.ProblemsSolved)
        {
            case 0:
                result = new ExamResult(2, 2, 6, "Bad result: nothing done.");
                break;
            case 1:
                result = new ExamResult(4, 2, 6, "Average result: nothing done.");
                break;
            case 2:
                result = new ExamResult(6, 2, 6, "Average result: nothing done.");
                break;
            default:
                // This should never happen.
                throw new NotImplementedException("The given number of ProblemsSolved is not implemented.");
        }

        return result;
    }
}