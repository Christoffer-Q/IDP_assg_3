using System;

class Program
{
    static public void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }

    private void run() {
        Element oxygen = new Element(
            "Oxygen", 8, Type.NonMetal, 54.36, 90.188
        );
        Element iron = new Element(
            "Iron", 26, Type.Metal, 1811.0, 3134.0 
        );
        Element gold = new Element(
            "Gold", 79, Type.Metal, 1337.33, 3243
        );
    }
}