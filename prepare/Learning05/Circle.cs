using System;

public class Circle: Shape
{
    double _radius = 0;

    public Circle(double r)
    {
        _radius = r;
    }
    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area; 
    }
}
