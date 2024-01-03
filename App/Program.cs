using System;
using Interop;

public class Program
{
    public static void Main()
    {
        Functions.Print();

        Console.WriteLine("Now this is programming in c#");
        Rect rect = new Rect(0, 0, 100, 100);
        Point point = new Point(50, 50);

        if (Functions.CheckcollisionPoint(point, rect))
        {
            Console.WriteLine("point is inside rect");
        }
        else
        {
            Console.WriteLine("point is outside rect");
        }

        Console.ReadLine();
    }
}