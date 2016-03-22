namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;

    using Exceptions_Homework.Models;
    using Exceptions_Homework.Utilities;

    internal static class ExceptionsTestExamples
    {
        private static void Main()
        {
            var substr = StringUtilities.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = StringUtilities.Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = StringUtilities.Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = StringUtilities.Subsequence(new[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(StringUtilities.ExtractEnding("I love C#", 2));
            Console.WriteLine(StringUtilities.ExtractEnding("Nakov", 4));
            Console.WriteLine(StringUtilities.ExtractEnding("beer", 4));

            // Console.WriteLine(ExtractEnding("Hi", 100));
            Console.WriteLine("23 is prime? {0}", MathUtilities.CheckPrime(23));
            Console.WriteLine("33 is prime? {0}", MathUtilities.CheckPrime(33));

            List<Exam> peterExams = new List<Exam>
                                        {
                                            new SimpleMathExam(2), 
                                            new CSharpExam(55), 
                                            new CSharpExam(100), 
                                            new SimpleMathExam(1), 
                                            new CSharpExam(0)
                                        };

            Student peter = new Student("Peter", "Petrov", peterExams);

            double peterAverageResult = peter.CalculateAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}