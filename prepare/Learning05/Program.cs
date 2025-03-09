using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // SQUARE
        Square s1 = new Square("blue", 5);
        double squareArea = s1.GetArea();
        string squareColor = s1.GetColor();
        Console.WriteLine($"Area of Square is {squareArea} and the color is {squareColor}");

        // RECTANGLE
        Rectangle r1 = new Rectangle("red", 5, 10);
        double rectangleArea = r1.GetArea();
        string rectangleColor = r1.GetColor();
        Console.WriteLine($"Area of Rectangle is {rectangleArea} and the color is {rectangleColor}");

        // CIRCLE
        Circle c1 = new Circle("purple", 10);
        double circleArea = c1.GetArea();
        string circleColor = c1.GetColor();
        Console.WriteLine($"Area of Circle is {circleArea} and the color is {circleColor}");

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(c1);
        shapesList.Add(r1);
        shapesList.Add(s1);

        foreach (Shape s in shapesList)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The shape with color {color} has this size of area: {area}");
        }
    }
}