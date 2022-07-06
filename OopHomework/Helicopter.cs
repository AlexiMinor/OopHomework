namespace OopHomework;

public class Helicopter : IFlyingObject
{
    public string RegistrationNumber { get; set; }
    public int MaxDistance { get; set; }
    public int FuelConsumption { get; set; }

    public void Fly(int distance)
    {
        throw new NotImplementedException();
    }
}