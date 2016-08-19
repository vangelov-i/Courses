using System;

namespace NullableTypes
{
    class NullTypes
    {
        static void Main()
        {
            int? num;
            num = null;
            num += 5 +45;
            num = 10;
            Console.WriteLine(num);
        }
    }
}
