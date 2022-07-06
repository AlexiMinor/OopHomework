using OopHomework.Helpers;

namespace OopHomework.Factory;

public class BoeingFactory : AbstractAircraftFactory
{
    public override IPassengerFlyingObject CreatePassengerAircraft(PassengerPlaneVersion version)
    {
        switch (version)
        {
            case PassengerPlaneVersion.Efficient:
                var efPassengerPlane = new PassengerPlane()
                {
                    RegistrationNumber = RegistrationNumberGenerator.GenerateRegisterNumber(),
                    Model = "Boeing 737 NEO",
                    PassengerCapacity = 220,
                    FuelConsumption = 555,
                    MaxDistance = 5460
                };
                return efPassengerPlane;

            case PassengerPlaneVersion.Luxury:
                var luxPassPlane = new PassengerPlane()
                {
                    Model = "Boeing Business Jet",
                    PassengerCapacity = 20,
                    FuelConsumption = 300,
                    MaxDistance = 6000
                };
                return luxPassPlane;

            case PassengerPlaneVersion.LongRange:
                var lrPassPlane = new PassengerPlane()
                {
                    Model = "Boeing 777X",
                    PassengerCapacity = 400,
                    FuelConsumption = 700,
                    MaxDistance = 12000
                };
                return lrPassPlane;

            default:
                throw new ArgumentException("Non known plane type");
        }

      
    }

    public override ICargoFlyingObject CreateCargoAircraft(CargoPlaneVersion version)
    {
        switch (version)
        {
            case CargoPlaneVersion.Min:
            {
                var smallCargo = new CargoPlane()
                {
                    Model = "Small Cargo Boeing",
                    MaxDistance = 5000,
                    FuelConsumption = 400,
                    CargoCapacity = 5000
                };
                return smallCargo;
            }
            case CargoPlaneVersion.Max:
            {
                var bigCargoPlane = new CargoPlane()
                {
                    Model = "Big Cargo Boeing",
                    MaxDistance = 4000,
                    FuelConsumption = 500,
                    CargoCapacity = 15000
                };
                return bigCargoPlane;
            }
            default:
                throw new ArgumentException();
        }
    }
}