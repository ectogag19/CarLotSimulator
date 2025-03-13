using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"A {Make} {Model} has an engine noise that sounds like {EngineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"A {Make} {Model} has a honk noise that sounds like {HonkNoise}.");
    }

    public Car()
    {
        
    }

    public Car(string make, string model, int year, bool isDrivable)
    {
        Make = make;
        Model = model;
        Year = year;
        IsDrivable = isDrivable;
    }
}