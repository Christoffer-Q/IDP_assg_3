using System;

class Program
{
    static public void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }

    private void run()
    {
        Element oxygen = new Element(
            "Oxygen", 8, Type.NonMetal, 54.36, 90.188
        );
        Element iron = new Element(
            "Iron", 26, Type.Metal, 1811.0, 3134.0
        );
        Element gold = new Element(
            "Gold", 79, Type.Metal, 1337.33, 3243
        );

        System.Console.WriteLine("\n=== Task 3. ===");
        oxygen.PrintElement();

        System.Console.WriteLine("\n=== Task 4. ===");
        Element[] elements = new Element[6];
        elements[0] = oxygen;
        elements[1] = iron;
        elements[2] = gold;
        elements[3] = new Element(
            "Hydrogen", 1, Type.NonMetal, 13.99, 20.271
        );
        elements[4] = new Element(
            "Bromine", 35, Type.NonMetal, 265.8, 332.0
        );
        elements[5] = new Element(
            "Quicksilver", 80, Type.Metal, 234.3210, 629.88
        );

        System.Console.WriteLine("\n=== Task 5. ===");
        foreach (Element element in elements)
        {
            element.PrintElement();
        }

        System.Console.WriteLine("\n=== Task 6. ===");
        foreach (Element element in elements) {
            System.Console.WriteLine("Element name: {0}", element.Name);
        }

        System.Console.WriteLine("\n=== Task 7. ===");
        foreach (Element element in elements)
        {
            if (element.MeltingPoint < 273.16 && element.BoilingPoint > 273.16)
            {
                element.PrintElement();
            }
        }
    }
}