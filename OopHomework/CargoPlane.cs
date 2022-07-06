namespace OopHomework;

public class CargoPlane : Plane, ICargoFlyingObject
{
    public int CargoCapacity { get; set; }

    public void FlyWithPassenger(int cargoAmount, int distance)
    {
        if (MaxDistance >= distance && CargoCapacity >= cargoAmount)
        {
            Fly(distance);
            Console.WriteLine($"Plane {RegistrationNumber} transfered {cargoAmount}kg weight");
        }
        else
        {
            if (MaxDistance < distance)
            {
                Console.WriteLine(
                    $"Plane {RegistrationNumber} can't transfer passengers because max. flight distance is {MaxDistance}km");
            }

            if (CargoCapacity < cargoAmount)
            {
                Console.WriteLine(
                    $"Plane {RegistrationNumber} can't transfer passengers because weight limit is {CargoCapacity}");
            }
        }
    }
}