namespace OopHomework;

public abstract class Plane : IFlyingObject
{
    public string RegistrationNumber { get; set; }
    public int MaxDistance { get; set; }
    public int FuelConsumption { get; set; } //L/100km]

    public string Model { get; set; }

    public virtual void Fly(int distance)
    {
        Console.WriteLine($"Plane {RegistrationNumber} fly on distance {distance}km. Fuel consumption for flight is {distance/100.0*FuelConsumption}");
    }
}