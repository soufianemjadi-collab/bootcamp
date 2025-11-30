// // Sphere Challenge
using System;
using System.Collections.Generic;
public class Sphere : IComparable<Sphere>
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set => _radius = value > 0 ? value : 0;
    }

    public double Diameter
    {
        get => _radius * 2;
        set => _radius = value > 0 ? value / 2 : 0;
    }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public static Sphere FromDiameter(double diameter)
    {
        return new Sphere(diameter / 2);
    }

    public double Volume => 4.0 / 3.0 * Math.PI * Math.Pow(_radius, 3);

    public double Surface => 4 * Math.PI * Math.Pow(_radius, 2);

    public override string ToString()
    {
        return $"Sphere(R={Radius:F2}, D={Diameter:F2}, Vol={Volume:F2})";
    }

    // Add spheres → new sphere with combined radius
    public static Sphere operator +(Sphere a, Sphere b)
    {
        return new Sphere(a.Radius + b.Radius);
    }

    // Compare by volume
    public static bool operator >(Sphere a, Sphere b) => a.Volume > b.Volume;
    public static bool operator <(Sphere a, Sphere b) => a.Volume < b.Volume;

    // Compare by radius (equal)
    public static bool operator ==(Sphere a, Sphere b) => a.Radius == b.Radius;
    public static bool operator !=(Sphere a, Sphere b) => a.Radius != b.Radius;

    // Sorting (default → by radius)
    public int CompareTo(Sphere other)
    {
        return Radius.CompareTo(other.Radius);
    }
}

class Program
{
    static void Main()
    {
        Sphere s1 = new Sphere(3);
        Sphere s2 = Sphere.FromDiameter(10);

        Console.WriteLine(s1);
        Console.WriteLine(s2);

        Sphere s3 = s1 + s2;
        Console.WriteLine("Added: " + s3);

        Console.WriteLine(s1 > s2);
        Console.WriteLine(s1 == s2);

        var list = new List<Sphere> { s3, s1, s2 };
        list.Sort(); // by radius

        Console.WriteLine("\nSorted:");
        foreach (var s in list) Console.WriteLine(s);
    }
}
