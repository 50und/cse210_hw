using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>{};
        Square square = new Square(5);
        square.SetColor("blue");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(5,5);
        rectangle.SetColor("orange");
        shapes.Add(rectangle);

        Circle circle = new Circle(3);
        circle.SetColor("yellow");
        shapes.Add(circle);      

        foreach (Shape shape in shapes)
        {
            Console.WriteLine();
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        } 


    }
}