using System;

class Element
{
    public string Name;
    public int Z;
    public Type Type;
    public double MeltingPoint;
    public double BoilingPoint;

    public Element(string name, int z, Type type, double meltingPoint, double boilingPoint)
    {
        Name = name;
        Z = z;
        Type = type;
        MeltingPoint = meltingPoint;
        BoilingPoint = boilingPoint;
    }

    public void PrintElement()
    {
        System.Console.WriteLine(
            "Element: {0,5}\n Type: {1,5}\n Melting point: {2,5:F} K\n Boiling point: {3,5:F} K"
            , Name, Type, MeltingPoint, BoilingPoint
        );
    }

}