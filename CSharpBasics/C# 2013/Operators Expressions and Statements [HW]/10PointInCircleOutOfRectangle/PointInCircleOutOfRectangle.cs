using System;

//Write an expression that checks for given point (x, y) 
//if it is within the circle K({1, 1}, 1.5) and out of 
//the rectangle R(top=1, left=-1, width=6, height=2). 
//Examples:

//  x	        y	        inside K & outside of R	 
//  1	        2	        yes	
//  2.5	    2	        no	
//  0	        1	        no	
//  2.5	    1	        no	
//  2	        0	        no	
//  4	        0	        no	
//  2.5	    1.5	        no	
//  2	        1.5	        yes	
//  1	        2.5	        yes	
//  -100	    -100	    no	

namespace _10PointInCircleOutOfRectangle
{
    class PointInCircleOutOfRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine()) -1;
            double y = double.Parse(Console.ReadLine()) -1;
            //this way (with -1) we move the center of the circle to be K({0,0},1.5)
            //and the same logic applies to the rectangle (e.g. it's top now is 0 instead of 1)

            double radius = Math.Sqrt(x * x + y * y); // Pythagore (c^2 = a^2 + b^2)
            if (y > 0 && radius <= 1.5)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
