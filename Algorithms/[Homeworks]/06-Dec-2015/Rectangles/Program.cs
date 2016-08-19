using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

// 21:20 - 22:30 -> 20/100 
// 23:15 - 12:00 -> 45/100
// 12:00 - 1:00 -> 50/100
class Program
{
    private static Dictionary<int, int> rectIndexNestedCount;
    private static List<Rectangle> rectanglesSt;

    static void Main(string[] args)
    {
        var rectangles = new List<Rectangle>();
        rectIndexNestedCount = new Dictionary<int, int>();

        string currentLine = Console.ReadLine();
        while (currentLine != "End")
        {
            string[] lineParams = currentLine
                .Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            string name = lineParams[0];
            int leftX = int.Parse(lineParams[1]);
            int upY = int.Parse(lineParams[2]);

            int rightX = int.Parse(lineParams[3]);
            int downY = int.Parse(lineParams[4]);

            var currentRectangle = new Rectangle(name, leftX, rightX, downY, upY);
            rectangles.Add(currentRectangle);

            currentLine = Console.ReadLine();
        }

        rectangles = rectangles.OrderBy(r => r.Area).ToList();
        int maxNestedCount = 0;
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < rectangles.Count; i++)
        {
            var currentNestedRectangles = new List<string>();
            var currentRect = rectangles[i];
            currentNestedRectangles.Add(currentRect.Name);

            for (int j = i + 1; j < rectangles.Count; j++)
            {
                var nestedCandidate = rectangles[j];
                if (RectangleIsNested(currentRect, nestedCandidate))
                {
                    currentNestedRectangles.Add(nestedCandidate.Name);
                    currentRect = nestedCandidate;
                }
            }

            int currentNestedCount = currentNestedRectangles.Count;
            if (maxNestedCount < currentNestedCount)
            {
                output.Clear();
                for (int j = currentNestedRectangles.Count - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        output.Append(currentNestedRectangles[j]);
                        break;
                    }
                    output.Append(currentNestedRectangles[j] + " < ");
                }
                // output.Append(string.Join(" < ", currentNestedRectangles));

                maxNestedCount = currentNestedCount;
            }
            else if (maxNestedCount == currentNestedCount)
            {
                var currentNestedOutput = new StringBuilder();
                for (int j = currentNestedRectangles.Count - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        currentNestedOutput.Append(currentNestedRectangles[j]);
                        break;
                    }
                    currentNestedOutput.Append(currentNestedRectangles[j] + " < ");
                }

                string prevOutput = output.ToString();
                if (currentNestedOutput.ToString().CompareTo(prevOutput) == -1)
                {
                    output.Clear();
                    output.Append(currentNestedOutput);
                }
            }
        }

        Console.WriteLine(output);
    }

    private static List<Rectangle> GetNestedRects(int index)
    {
        var result = new List<Rectangle>();

        var currentRect = rectanglesSt[index];
        for (int j = index + 1; j < rectanglesSt.Count; j++)
        {
            var candidate = rectanglesSt[j];
            if (RectangleIsNested(candidate, currentRect))
            {
                result.Add(candidate);
                // currentNestedRectangles.Add(nestedCandidate.Name);
                //currentRect = nestedCandidate;
            }
        }

        return result;
    }

    static bool RectangleIsNested(Rectangle smaller, Rectangle bigger)
    {
        if (smaller.Area >= bigger.Area) //  || smaller.Name == bigger.Name
        {
            return false;
        }

        bool AIsInside = smaller.Ax >= bigger.Ax && smaller.Ay >= bigger.Ay;
        bool BIsInside = smaller.Bx <= bigger.Bx && smaller.By >= bigger.By;
        bool CIsInside = smaller.Cx <= bigger.Cx && smaller.Cy <= bigger.Cy;
        bool DIsInside = smaller.Dx >= bigger.Dx && smaller.Dy <= bigger.Dy;
        // bool areaIsSmaller = smaller.Area < bigger.Area; // this is questionable

        /*
        bool smallerX1IsInside = smaller.X1 >= bigger.X1;
        bool smallerX2IsInside = smaller.X2 <= bigger.X2;

        bool smallerY1IsInside = smaller.Y1 >= bigger.Y1;
        bool smallerY2IsInside = smaller.Y2 <= bigger.Y2;
        */

        bool smallerIsNested = AIsInside && BIsInside && CIsInside && DIsInside;

        return smallerIsNested;
    }
}

class Rectangle
{
    public Rectangle(string name, int leftX, int rightX, int downY, int upY)
    {
        this.Name = name;

        this.Ax = leftX;
        this.Ay = downY;

        // this.PointA = new Point(this.Ax, this.Ay);

        this.Bx = rightX;
        this.By = downY;

        this.Cx = rightX;
        this.Cy = upY;

        this.Dx = leftX;
        this.Dy = upY;


        this.SideA = (ulong)Math.Abs(this.Bx - this.Ax);
        this.SideB = (ulong)Math.Abs(this.Cy - this.Ay);

        this.Children = new List<Rectangle>();
    }

    // public Point PointA { get; set; }

    public int Ax { get; set; }
    public int Ay { get; set; }

    public int Bx { get; set; }
    public int By { get; set; }

    public int Cx { get; set; }
    public int Cy { get; set; }

    public int Dx { get; set; }
    public int Dy { get; set; }

    public string Name { get; set; }

    public ulong SideA { get; set; }

    public ulong SideB { get; set; }

    public ulong Area
    {
        get
        {
            return this.SideA * this.SideB;
        }
    } // this.SideA * this.SideB;

    public List<Rectangle> Children { get; set; }

    public override string ToString()
    {
        return this.Name + " A: " + this.Area;
    }
}

class Point
{
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }
}