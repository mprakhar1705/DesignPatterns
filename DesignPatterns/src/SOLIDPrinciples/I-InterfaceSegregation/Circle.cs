using System;

namespace DesignPatterns.src.SOLIDPrinciples.I_InterfaceSegregation;

public class Circle : IShape2D
{
    public int Radius { get; set; }
    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
