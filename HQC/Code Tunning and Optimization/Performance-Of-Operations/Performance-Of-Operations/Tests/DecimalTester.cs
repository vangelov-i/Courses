namespace Performance_Of_Operations.Tests
{
    using System;
    using System.Diagnostics;

    public class DecimalTester : INumbersOperationsTester
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        private decimal testNumber;

        public Stopwatch StopWatch
        {
            get
            {
                return this.stopwatch;
            }
        }

        public void Add()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5m + 4;
            }

            this.stopwatch.Stop();
        }

        public void Substract()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5m - 4;
            }

            this.stopwatch.Stop();
        }

        public void IncrementByPrefix()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                ++this.testNumber;
            }

            this.stopwatch.Stop();
        }

        public void IncrementBySufix()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber++;
            }

            this.stopwatch.Stop();
        }

        public void IncrementByOperators()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber += 1;
            }

            this.stopwatch.Stop();
        }

        public void Multiply()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 4 * 5m;
            }

            this.stopwatch.Stop();
        }

        public void Divide()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5m / 4;
            }

            this.stopwatch.Stop();
        }

        public void SquareRoot()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = (decimal)Math.Sqrt(50.0);
            }

            this.stopwatch.Stop();
        }

        public void Log()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = (decimal)Math.Log(50.0);
            }

            this.stopwatch.Stop();
        }

        public void Sin()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0m;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = (decimal)Math.Sin(50.0);
            }

            this.stopwatch.Stop();
        }

    }
}