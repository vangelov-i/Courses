using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace _12AprilEvening02EvenElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string strInput = Console.ReadLine();
            string[] array = strInput.Split(' ');

            if (strInput == "" || strInput == " ")
            {
                 Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else
            {
                double[] numbers = new double[array.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = double.Parse(array[i]);
                }

                int oddCounter = 0;
                double evenSum = 0.0;
                double oddSum = 0.0;

                for (int i = 0; i < numbers.Length; i += 2)
                {
                    oddCounter++;
                    oddSum += numbers[i];
                }
                int evenCounter = numbers.Length - oddCounter;

                double[] oddArray = new double[oddCounter];
                double[] evenArray = new double[evenCounter];

                for (int i = 1; i < numbers.Length; i += 2)
                {
                    evenSum += numbers[i];
                }

                int oddArrCounter = 0;
                int evenArrCounter = 0;
                for (int i = 0; i < numbers.Length; i += 2)
                {
                    oddArray[oddArrCounter] = numbers[i];
                    oddArrCounter++;
                }
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    evenArray[evenArrCounter] = numbers[i];
                    evenArrCounter++;
                }

                if (evenCounter == 0)
                {
                    Console.WriteLine
                    (
                    "OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No"
                    , oddSum, oddArray.Min(), oddArray.Max()
                    );
                }
                else
                {
                    Console.WriteLine
                        (
                        "OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}"
                        , oddSum, oddArray.Min(), oddArray.Max(), evenSum, evenArray.Min(), evenArray.Max()
                        );
                }
            }
        }
    }
}
