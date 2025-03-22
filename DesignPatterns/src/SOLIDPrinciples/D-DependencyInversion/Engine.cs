using System;

namespace DesignPatterns.src.SOLIDPrinciples.D_DependencyInversion;

public class Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine starting...");
    }
}
