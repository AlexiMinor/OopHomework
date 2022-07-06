namespace OopHomework.Helpers;

public class DistancePlaneComparer : IComparer<Plane>
{
    public int Compare(Plane x, Plane y)
    {
        if (y == null)
            return 1;
        if (x == null)
            return -1;
        if (x.Equals(y)) 
            return 0;
     
        return x.MaxDistance.CompareTo(y.MaxDistance);
    }
}