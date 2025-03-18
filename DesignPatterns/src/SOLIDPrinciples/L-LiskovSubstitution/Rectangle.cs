using System;

namespace DesignPatterns.src.SOLIDPrinciples.L_LiskovSubstitution;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area => Width * Height;
}
