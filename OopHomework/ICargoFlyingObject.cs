namespace OopHomework;

public interface ICargoFlyingObject : IFlyingObject
{
    public int CargoCapacity { get; set; }
}

public interface IPassengerFlyingObject : IFlyingObject
{
    public int PassengerCapacity { get; set; }
}