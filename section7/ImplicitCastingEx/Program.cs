using System;

class Program
{
    static void Main()
    {
        sbyte a = 10; // lower numerical type 
        int b; // higher numerical type 
        b = a;// implicit casting 
        Console.WriteLine(a);
        Console.WriteLine(b);

        char character = 'A';
        int ascivalue = character;

        Console.WriteLine(character);
        Console.WriteLine(ascivalue);
        Console.ReadKey();



    }
}