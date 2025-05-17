using System;

class Program
{
    static void Main()
    {
        // explicit casting can work in all cases of implicit casting
        // refer to the table 
        int a = 100; // higher numerical vale 
        byte b; // lower numerical value 
        b = (byte)a; // explicity conversion
        Console.WriteLine(a);
        Console.WriteLine(b);

        // loosy conversion 
        int c = 500;
        byte d;
        d = (byte)c;
        Console.WriteLine(c);
        Console.WriteLine(d);

        Console.ReadKey();

    }
}