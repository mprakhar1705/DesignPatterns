using System;

namespace DesignPatterns.src.SOLIDPrinciples.L_LiskovSubstitution;

public class Square: Shape
{
    public double Side { get; set; }
    public override double Area => Math.Pow(Side, 2);
}
