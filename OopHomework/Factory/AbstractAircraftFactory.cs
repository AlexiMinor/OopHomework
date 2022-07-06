namespace OopHomework.Factory;

public abstract class AbstractAircraftFactory
{
    public abstract IPassengerFlyingObject CreatePassengerAircraft(PassengerPlaneVersion version);
    public abstract ICargoFlyingObject CreateCargoAircraft(CargoPlaneVersion version);
}