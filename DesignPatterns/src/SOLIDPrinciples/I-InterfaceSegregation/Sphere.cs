using System;

namespace DesignPatterns.src.SOLIDPrinciples.I_InterfaceSegregation;

public class Sphere: IShape3D
{
    public int Radius { get; set; }
    public double Volume()
    {
        return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
    }
    public double Area()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
}

