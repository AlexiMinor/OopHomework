namespace OopHomework;

public class PassengerPlane : Plane, IPassengerFlyingObject
{
    public int PassengerCapacity { get; set; }

    public void FlyWithPassenger(int passengersAmount, int distance)
    {
        if (MaxDistance >= distance && PassengerCapacity >= passengersAmount)
        {
            Fly(distance);
            Console.WriteLine($"Plane {RegistrationNumber} transfered {passengersAmount} of passengers");
        }
        else
        {
            if (MaxDistance < distance)
            {
                Console.WriteLine(
                    $"Plane {RegistrationNumber} can't transfer passengers because max. flight distance is {MaxDistance}km");
            }

            if (PassengerCapacity < passengersAmount)
            {
                Console.WriteLine(
                    $"Plane {RegistrationNumber} can't transfer passengers because passenger capacity is {PassengerCapacity}");
            }
        }
    }
}