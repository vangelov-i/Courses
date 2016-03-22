namespace Performance_Of_Operations.Tests
{
    using System.Diagnostics;

    public class IntTester : INumbersOperationsTester
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        private int testNumber;

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

            this.testNumber = 0;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5 + 4;
            }

            this.stopwatch.Stop();
        }

        public void Substract()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5 - 4;
            }

            this.stopwatch.Stop();
        }

        public void IncrementByPrefix()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0;
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

            this.testNumber = 0;
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

            this.testNumber = 0;
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

            this.testNumber = 0;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 4 * 5;
            }

            this.stopwatch.Stop();
        }

        public void Divide()
        {
            this.stopwatch.Reset();
            this.stopwatch.Start();

            this.testNumber = 0;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5 / 4;
            }

            this.stopwatch.Stop();
        }
    }
}