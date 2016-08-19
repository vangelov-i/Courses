using System;

namespace P13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double number1a = 5.3;
            double number1b = 6.01;
            double substracted1 = Math.Abs(number1a - number1b);
            bool difference1 = substracted1 < 0.000001;
            Console.WriteLine("Equal = {0}", difference1);
            //if (substracted1 > 0.000001)
            //{
            //    difference1 = false;
            //    Console.WriteLine("The difference of {0} is too big (>eps), Equal (with precision eps=0.000001)={1}", substracted1, difference1);
                
            //}
            //else
            //{
            //    difference1 = true;
            //    Console.WriteLine("The difference {0} < eps, Equal (with precision eps=0.000001)={1}", substracted1, difference1);
            //}

            //double number2a = 5.00000001;
            //double number2b = 5.00000003;
            //double substracted2 = Math.Abs(number2a - number2b);
            //bool difference2;
            //if (substracted2 > 0.000001)
            //{
            //    difference2 = false;
            //    Console.WriteLine("The difference {0} is too big (>eps), Equal (with precision eps=0.000001)={1}", substracted2.ToString("F8"), difference2);
            //}
            //else
            //{
            //    difference2 = true;
            //    Console.WriteLine("The difference {0} < eps, Equal (with precision eps=0.000001)={1}", substracted2.ToString("F8"), difference2);
            //}

            //double number3a = 5.00000005;
            //double number3b = 5.00000001;
            //double substracted3 = Math.Abs(number3a - number3b);
            //if (substracted3 > 0.000001)
            //{
            //    Console.WriteLine("The difference {0} is too big (>eps)", substracted3.ToString("F8"));
            //}
            //else
            //{
            //    Console.WriteLine("The difference {0} < eps", substracted3.ToString("F8"));
            //}

            //double number4a = -4.999999;
            //double number4b = -4.999998;
            //double substracted4 = Math.Abs(number4a - number4b);
            //if (substracted4 > 0.000001)
            //{
            //    Console.WriteLine("The difference {0} is too big (>eps)", substracted4.ToString("F8"));
            //}
            //else
            //{
            //    Console.WriteLine("The difference {0} < eps", substracted4.ToString("F8"));
            //}
        }
    }
}
