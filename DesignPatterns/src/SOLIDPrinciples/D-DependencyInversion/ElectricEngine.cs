using System;

namespace DesignPatterns.src.SOLIDPrinciples.D_DependencyInversion;

public class ElectricEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Electric engine starting...");
    }
}
