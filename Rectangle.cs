namespace Shapes;

public class Rectangle(double width, double height): Shape
{
    double Width {get; set;} = width;
    double Height {get; set;} = height;

    public override double GetArea()
    {
        return Width * Height;
        
    }
}
