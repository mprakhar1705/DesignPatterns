using System;

namespace DesignPatterns.src.SOLIDPrinciples.D_DependencyInversion;

public class Car
{
    private IEngine engine;

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void StartCar()
    {
        engine.Start();
    }
}
