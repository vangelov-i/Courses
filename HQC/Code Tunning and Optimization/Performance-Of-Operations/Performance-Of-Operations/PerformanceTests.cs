namespace Performance_Of_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Performance_Of_Operations.Tests;

    /// <summary>
    /// PerformanceTests is used to check the performance of mathematical operations (+, -, ++, *, / etc.).
    /// The tested types are int, long, float, double and decimal.
    /// </summary>
    public class PerformanceTests
    {
        private static void Main()
        {
            var addOperationData = new Dictionary<string,string>();

            var intTestsData = new Dictionary<string, string>();
            IntTester intTester = new IntTester();
            #region int testing
            intTester.Add();
            intTestsData.Add("Add".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());

            intTester.Substract();
            intTestsData.Add("Substract".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());

            intTester.IncrementByPrefix();
            intTestsData.Add("++(prefix)".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());

            intTester.IncrementBySufix();
            intTestsData.Add("(sufix)++".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());

            intTester.IncrementByOperators();
            intTestsData.Add("+=1".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());

            intTester.Multiply();
            intTestsData.Add("*".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());

            intTester.Divide();
            intTestsData.Add("/".PadLeft(11, ' '), intTester.StopWatch.Elapsed.ToString());
            #endregion

            var longTestsData = new Dictionary<string, string>();
            LongTester longTester = new LongTester();
            #region long testing
            longTester.Add();
            longTestsData.Add("Add".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());

            longTester.Substract();
            longTestsData.Add("Substract".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());

            longTester.IncrementByPrefix();
            longTestsData.Add("++(prefix)".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());

            longTester.IncrementBySufix();
            longTestsData.Add("(sufix)++".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());

            longTester.IncrementByOperators();
            longTestsData.Add("+=1".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());

            longTester.Multiply();
            longTestsData.Add("*".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());

            longTester.Divide();
            longTestsData.Add("/".PadLeft(11, ' '), longTester.StopWatch.Elapsed.ToString());
            #endregion

            var floatTestsData = new Dictionary<string, string>();
            FloatTester floatTester = new FloatTester();
            #region float testing
            floatTester.Add();
            floatTestsData.Add("Add".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());

            floatTester.Substract();
            floatTestsData.Add("Substract".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());

            floatTester.IncrementByPrefix();
            floatTestsData.Add("++(prefix)".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());

            floatTester.IncrementBySufix();
            floatTestsData.Add("(sufix)++".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());

            floatTester.IncrementByOperators();
            floatTestsData.Add("+=1".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());

            floatTester.Multiply();
            floatTestsData.Add("*".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());

            floatTester.Divide();
            floatTestsData.Add("/".PadLeft(11, ' '), floatTester.StopWatch.Elapsed.ToString());
            #endregion

            var doubleTestsData = new Dictionary<string, string>();
            DoubleTester doubleTester = new DoubleTester();
            #region double testing
            doubleTester.Add();
            doubleTestsData.Add("Add".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.Substract();
            doubleTestsData.Add("Substract".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.IncrementByPrefix();
            doubleTestsData.Add("++(prefix)".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.IncrementBySufix();
            doubleTestsData.Add("(sufix)++".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.IncrementByOperators();
            doubleTestsData.Add("+=1".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.Multiply();
            doubleTestsData.Add("*".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.Divide();
            doubleTestsData.Add("/".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.SquareRoot();
            doubleTestsData.Add("Math.Sqrt()".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.Log();
            doubleTestsData.Add("Math.Log()".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());

            doubleTester.Sin();
            doubleTestsData.Add("Math.Sin()".PadLeft(11, ' '), doubleTester.StopWatch.Elapsed.ToString());
            #endregion

            var decimalTestsData = new Dictionary<string, string>();
            DecimalTester decimalTester = new DecimalTester();
            #region decimal testing
            decimalTester.Add();
            decimalTestsData.Add("Add".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.Substract();
            decimalTestsData.Add("Substract".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.IncrementByPrefix();
            decimalTestsData.Add("++(prefix)".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.IncrementBySufix();
            decimalTestsData.Add("(sufix)++".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.IncrementByOperators();
            decimalTestsData.Add("+=1".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.Multiply();
            decimalTestsData.Add("*".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.Divide();
            decimalTestsData.Add("/".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.SquareRoot();
            decimalTestsData.Add("Math.Sqrt()".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.Log();
            decimalTestsData.Add("Math.Log()".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());

            decimalTester.Sin();
            decimalTestsData.Add("Math.Sin()".PadLeft(11, ' '), decimalTester.StopWatch.Elapsed.ToString());
            #endregion

            Console.WriteLine("int results:");
            foreach (var key in intTestsData)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nlong results:");
            foreach (var key in longTestsData)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nfloat results:");
            foreach (var key in floatTestsData)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\ndouble results:");
            foreach (var key in doubleTestsData)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\ndecimal results:");
            foreach (var key in decimalTestsData)
            {
                Console.WriteLine(key);
            }
        }
    }
}
