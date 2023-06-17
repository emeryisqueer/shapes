using System;
using System.Diagnostics;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare all shapes
            float width1 = 2;
            float height1 = 8;

            float width2 = 3;
            float height2 = 3;

            // Print the details of each
            Debug.WriteLine("Shape 1");
            Debug.WriteLine($"    Area: {width1 * height1}");
            Debug.WriteLine($"    Perimeter: {2*width1 + 2*height1}");

            Debug.WriteLine("Shape 2");
            Debug.WriteLine($"    Area: {width2 * height2}");
            Debug.WriteLine($"    Perimeter: {2 * width2 + 2 * height2}");
        }
    }
}