using ShapesInheritance.Shapes_Classes;
using System;

namespace ShapesInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes triangle = new Triangle(3, 3, 4);
            Console.WriteLine($"Triangle Area: {triangle.GetArea():n2}");
            Console.WriteLine($"Triangle Perimeter: {triangle.GetPerimeter()}");

            Shapes square = new Square(10);
            Console.WriteLine($"Square Area: {square.GetArea()}");
            Console.WriteLine($"Square Perimeter: {square.GetPerimeter()}");

            Shapes rectangle = new Rectangle(6, 8);
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.GetPerimeter()}");

            Shapes circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.GetArea():n2}");
            Console.WriteLine($"Circle Perimeter: {(circle as Circle).GetCircumference():n2}");

            Shapes hexagon = new Hexagon(10);
            Console.WriteLine($"Hexagon Area: {hexagon.GetArea():n2}");
            Console.WriteLine($"Hexagon Perimeter: {hexagon.GetPerimeter()}");

            bool isTriangleShape = triangle is Shapes;

            if (isTriangleShape)
            {
                Console.WriteLine("Triangle is a shape");
            }
        }
    }
}
//CAN SHAPES CLASS BE INTERFACE? (Please provide me feedback as to why shapes might or might not be a good candidate for an interface)
//Interface defines a contract. Any class or struct with an interface contract must provide an implmentation of members in Shape.
//If this is that case that means for all the shape classes(circle, rectangle, square, triangle, hexagon) will have to implement all fields, constructors, and methods found in Shape.
//Depending on the code, we wanted a branch of Shape, BUT we ended up bringing the whole tree.
//For example, if we do not want a colored shape, but want to implement an abstract method GetArea(), it does not matter.
//Due to the interface contract, we have to implement Set and Get Color.
//IF we made an interface, called ShapeMeasurements, with two abstract methods called GetArea() and GetPerimeter(), I think that would be a better interface to implement.






            //Triangle triangleOne = new Triangle(1, 2, 3);
            //bool colorSet = triangleOne.SetColor(null);
            //Console.WriteLine(colorSet);
            //triangleOne.SetColor("Red");

            //Square squareOne = new Square(5);
            //squareOne.SetColor("Blue");

            //Rectangle rectangleOne = new Rectangle(5, 6);
            //rectangleOne.SetColor("Green");

            //Circle circleOne = new Circle(10);
            //circleOne.SetColor("Yellow");

            //Console.WriteLine($"Color of the triangle is {triangleOne.GetColor()}");
            //Console.WriteLine($"Color of the square is {squareOne.GetColor()}");
            //Console.WriteLine($"Color of the triangle is {rectangleOne.GetColor()}");
            //Console.WriteLine($"Color of the triangle is {circleOne.GetColor()}");