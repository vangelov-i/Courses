namespace Performance_Of_Operations
{
    using System.Diagnostics;

    public interface INumbersOperationsTester
    {
        Stopwatch StopWatch { get; }

        void Add();

        void Substract();

        void IncrementByPrefix();

        void IncrementBySufix();

        void IncrementByOperators();

        void Multiply();

        void Divide();
    }
}