using System.Collections;
using OopHomework.Helpers;

namespace OopHomework;

public class AircraftCompany : IDictionary<string, IFlyingObject>
{
    private readonly Dictionary<string, IFlyingObject> _aircrafts;

    public long TotalPassengerCapacity()
    {
        long totalPassengerCapacity = 0;
        foreach (var flyingObject in Values)
        {
            if (flyingObject is IPassengerFlyingObject)
            {
                totalPassengerCapacity += ((IPassengerFlyingObject)flyingObject).PassengerCapacity;
            }
        }
        return totalPassengerCapacity;
    }

    public AircraftCompany()
    {
        _aircrafts = new Dictionary<string, IFlyingObject>();
    }

    #region IDictionary implementation
    public IEnumerator<KeyValuePair<string, IFlyingObject>> GetEnumerator()
    {
        return _aircrafts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(KeyValuePair<string, IFlyingObject> item)
    {
        _aircrafts.Add(item.Key, item.Value);
    }

    public void Clear()
    {
        _aircrafts.Clear();
    }

    public bool Contains(KeyValuePair<string, IFlyingObject> item)
    {
        return _aircrafts.Contains(item);
    }

    public void CopyTo(KeyValuePair<string, IFlyingObject>[] array, int arrayIndex)
    {
        
    }

    public bool Remove(KeyValuePair<string, IFlyingObject> item)
    {
        return _aircrafts.Remove(item.Key);
    }

    public int Count => _aircrafts.Count;
    
    public bool IsReadOnly => false;
    public void Add(string key, IFlyingObject value)
    {
        _aircrafts.Add(key, value);
    }

    public bool ContainsKey(string key)
    {
        return _aircrafts.ContainsKey(key);
    }

    public bool Remove(string key)
    {
        return _aircrafts.Remove(key);
    }

    public bool TryGetValue(string key, out IFlyingObject value)
    {
        return _aircrafts.TryGetValue(key, out value);
    }

    public IFlyingObject this[string key]
    {
        get => _aircrafts[key];
        set => _aircrafts[key] = value;
    }

    public ICollection<string> Keys => _aircrafts.Keys;
    public ICollection<IFlyingObject> Values => _aircrafts.Values;
    #endregion

    public void PrintAllPlanesSortedByMaxDistance()
    {
        var planesList = new List<Plane>();
        foreach (var aircraft in Values)
        {
            if (aircraft is Plane)
            {
                planesList.Add((Plane)aircraft);
            }
        }
        planesList.Sort(new DistancePlaneComparer());

        foreach (var plane in planesList)
        {
            Console.WriteLine($"Plane {plane.RegistrationNumber}. Distance {plane.MaxDistance}");
        }
    }

    public void PrintAllPlanesSortedByMaxDistanceWithLinq()
    {
        var sortedList = Values
            .OfType<Plane>()
            .OrderBy(plane => plane.MaxDistance)
            .ToList();

        foreach (var plane in sortedList)
        {
            Console.WriteLine($"Plane {plane.RegistrationNumber}. Distance {plane.MaxDistance}");
        }
    }


    public void FindMostEfficient(int minFuelConsumption, int maxFuelConsumption, int distance)
    {
        var planesList = new List<Plane>();
        foreach (var aircraft in Values)
        {
            if (aircraft.FuelConsumption >= minFuelConsumption 
                && aircraft.FuelConsumption<= maxFuelConsumption 
                && aircraft.MaxDistance >= distance)
            {
                planesList.Add((Plane)aircraft);
            }
        }

        if (planesList.Any())
        {
            planesList.Sort(new FuelConsumptionPlaneComparer());

            Console.WriteLine($"Plane {planesList[0].RegistrationNumber}.Fuel consumption {planesList[0].FuelConsumption}L/100km. Distance {planesList[0].MaxDistance}km");
        }
        else
        {
            Console.WriteLine("Aircraft company doesn't have plane for current requirement");
        }
    }

    public void FindMostEfficientPlaneWithLinq(int minFuelConsumption, int maxFuelConsumption, int distance)
    {
        var mostEfficientAirCraft = Values
            .FirstOrDefault(aircraft => aircraft.FuelConsumption >= minFuelConsumption
                                        && aircraft.FuelConsumption <= maxFuelConsumption
                                        && aircraft.MaxDistance >= distance);
        if (mostEfficientAirCraft != null)
        {
             Console.WriteLine($"Plane {mostEfficientAirCraft.RegistrationNumber}.Fuel consumption {mostEfficientAirCraft.FuelConsumption}L/100km. Distance {mostEfficientAirCraft.MaxDistance}km");
        }
    }
}
