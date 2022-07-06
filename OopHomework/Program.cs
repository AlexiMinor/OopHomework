using OopHomework.Factory;

namespace OopHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ryanair = new AircraftCompany();

            AbstractAircraftFactory boeingFactory = new BoeingFactory();

            var efficient1 = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.Efficient);
            var efficient2 = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.Efficient);
            var efficient3 = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.Efficient);
            var efficient4 = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.Efficient);
            var lux1 = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.Luxury);
            var lux2 = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.Luxury);
            var cargo1 = boeingFactory.CreateCargoAircraft(CargoPlaneVersion.Min);
            var cargo2 = boeingFactory.CreateCargoAircraft(CargoPlaneVersion.Max);
            var lr = boeingFactory.CreatePassengerAircraft(PassengerPlaneVersion.LongRange);

            ryanair.Add(efficient1.RegistrationNumber, efficient1);
            ryanair.Add(efficient2.RegistrationNumber, efficient2);
            ryanair.Add(efficient3.RegistrationNumber, efficient3);
            ryanair.Add(efficient4.RegistrationNumber, efficient4);

            ryanair.Add(lux1.RegistrationNumber, lux1);
            ryanair.Add(lux2.RegistrationNumber, lux2);
            ryanair.Add(cargo1.RegistrationNumber, cargo1);
            ryanair.Add(cargo2.RegistrationNumber, cargo2);
            ryanair.Add(lr.RegistrationNumber, lr);

            Console.WriteLine(ryanair.TotalPassengerCapacity());
        }
    }
}

