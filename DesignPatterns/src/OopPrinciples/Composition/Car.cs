using System;

namespace DesignPatterns.src.Composition;

public class Car
{
    private Engine engine = new Engine();
    private Wheels wheels = new Wheels();

    public void Start()
    {
        engine.Start();
        wheels.Rotate();
        Console.WriteLine("Car is starting.");
    }
}
