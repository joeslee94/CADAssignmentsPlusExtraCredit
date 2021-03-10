using System;

namespace Lab_Ch3_Methods_For_Geometric_Areas_and_Perimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle
            double circle1Radius = 1.0;
            //Console.WriteLine("Enter in a value for the radius of the circle.");
            //double userinputRadius = Convert.ToDouble(Console.ReadLine());
            CircleGetArea(circle1Radius);
            CircleGetPerimeter(circle1Radius);
            CircleGetGetAreaAndPerimeter(circle1Radius);

            //Rectangle
            double rectangleLength = 2.0;
            double rectangleWidth = 3.0;
            //Console.WriteLine("Enter in a value for the length of the rectangle.");
            //double userinputLength = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter in a value for the width of the rectangle.");
            //double userinputWidth = Convert.ToDouble(Console.ReadLine());
            RectangleGetArea(rectangleLength, rectangleWidth);
            RectangleGetPerimeter(rectangleLength, rectangleWidth);
            RectangleGetGetAreaAndPerimeter(rectangleLength, rectangleWidth);

            //Triangle
            double triangleSideA = 4.0;
            double triangleSideB = 5.0;
            double triangleSideC = 6.0;
            //Console.WriteLine("Enter in a value for the first side of the triangle.");
            //double userinputSideA = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter in a value for the second side of the triangle.");
            //double userinputSideB = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter in a value for the final side of the triangle.");
            //double userinputSideC = Convert.ToDouble(Console.ReadLine());
            TriangleGetArea(triangleSideA, triangleSideB, triangleSideC);
            TriangleGetPerimeter(triangleSideA, triangleSideB, triangleSideC);
            TriangleGetAreaAndPerimeter(triangleSideA, triangleSideB, triangleSideC);

        }
        //Circle Area + Perimeter
        static double CircleGetArea(double radius) // Circle
        {
            double circle1Area = Math.PI * radius * radius;
            Console.WriteLine($"Circle 1 Area is: {circle1Area}");
            return circle1Area;
        }
        static double CircleGetPerimeter(double radius) // Circle
        {
            double circle1Perimeter = Math.PI * 2 * radius;
            Console.WriteLine($"Circle 1 Perimeter: {circle1Perimeter}");
            return circle1Perimeter;
        }
        static (double cirarea, double cirperimeter) CircleGetGetAreaAndPerimeter(double radius)
        {
            double circle1Area = CircleGetArea(radius);
            double circle1Perimeter = CircleGetPerimeter(radius);

            Console.WriteLine($"Circle 1 Area is: {circle1Area}");
            Console.WriteLine($"Circle 1 Perimeter: {circle1Perimeter}\n");

            return (circle1Area, circle1Perimeter);
        }

        //Rectangle Area + Perimeter
        static double RectangleGetArea(double length, double width)
        {
            double rectanglearea = Math.Round(length * width, 1);
            Console.WriteLine($"Rectangle Area: {rectanglearea}");
            return rectanglearea;
        }
        static double RectangleGetPerimeter(double length, double width)
        {
            double rectangleperimeter = Math.Round(2 * (length + width), 1);
            Console.WriteLine($"Rectangle Perimeter: {rectangleperimeter}");
            return rectangleperimeter;
        }
        static (double recarea, double recperimeter) RectangleGetGetAreaAndPerimeter(double length, double width)
        {
            double rectanglearea = RectangleGetArea(length, width);
            double rectangleperimeter = RectangleGetPerimeter(length, width);
            Console.WriteLine($"Rectangle Area: {rectanglearea}");
            Console.WriteLine($"Rectangle Perimeter: {rectangleperimeter}\n");

            return (rectanglearea, rectangleperimeter);
        }

        //Triangle Area + Perimeter
        static double TriangleGetArea(double a, double b, double c)
        {
            double semiperimeter = (a + b + c) / 2;
            double trianglearea = Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c)), 1);
            Console.WriteLine($"Triangle Area: {trianglearea}");
            return trianglearea;
        }
        static double TriangleGetPerimeter(double a, double b, double c)
        {
            double triangleperimeter = a + b + c;
            Console.WriteLine($"Triangle Perimeter: {triangleperimeter}");
            return triangleperimeter;
        }
        static (double triarea, double triperimeter) TriangleGetAreaAndPerimeter(double a, double b, double c)
        {
            double trianglearea = TriangleGetArea(a, b, c);
            double triangleperimeter = TriangleGetPerimeter(a, b, c);
            
            Console.WriteLine($"Triangle Area: {trianglearea}");
            Console.WriteLine($"Triangle Perimeter: {triangleperimeter}");

            return (trianglearea, triangleperimeter);
        }
    }
}