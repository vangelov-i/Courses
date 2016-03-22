namespace Performance_Of_Operations.Tests
{
    using System.Diagnostics;

    public class LongTester : INumbersOperationsTester
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        private long testNumber;

        public Stopwatch StopWatch
        {
            get
            {
                return this.stopwatch;
            }
        }

        public void Add()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5L + 4;
            }

            this.StopWatch.Stop(); 
        }

        public void Substract()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5L - 4;
            }

            this.StopWatch.Stop();
        }

        public void IncrementByPrefix()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                ++this.testNumber;
            }

            this.StopWatch.Stop();
        }

        public void IncrementBySufix()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber++;
            }

            this.StopWatch.Stop();
        }

        public void IncrementByOperators()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber += 1;
            }

            this.StopWatch.Stop();
        }

        public void Multiply()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 4 * 5L;
            }

            this.StopWatch.Stop();
        }

        public void Divide()
        {
            this.StopWatch.Reset();
            this.StopWatch.Start();

            this.testNumber = 0L;
            for (int i = 0; i < 1000; i++)
            {
                this.testNumber = 5L / 4;
            }

            this.StopWatch.Stop();
        }
    }
}