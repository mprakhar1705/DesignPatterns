using System;

namespace DesignPatterns.src.SOLIDPrinciples.O_OpenClose;

public class Rectangle: Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
