namespace Shapes;

public class Circle (double radius) : Shape
{
    public double Radius {get; set;} = radius;

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
