using System;

public class Square: Shape
{
    private double _side = 0;
    public Square(double side)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}