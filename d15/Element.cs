using System;

class Element {
    public string Name;
    public int Z;
    public Type Type;
    public double MeltingPoint;
    public double BoilingPoint;

    public Element(string name, int z, Type type, double meltingPoint, double boilingPoint) {
        Name = name;
        Z = z;
        Type = type;
        MeltingPoint = meltingPoint;
        BoilingPoint = boilingPoint;
    }

}