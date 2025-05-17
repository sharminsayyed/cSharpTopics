using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter a number");
        string s = Console.ReadLine();

        // try parse  - checks type before parsing and avoid FormatException 
        // if string it not convertable the parsing does not take place and return false and avoid exception
        // if the string is convertable the parsing takes place 
        // the varaible is stored in the out directional varaible 
        // the retursn true if valid
        bool b = int.TryParse(s, out int result);
        if(b == true)
        {
            Console.WriteLine("convertion is successful");
            Console.WriteLine("parsed value :" + result);
        }
        else
        {
            Console.WriteLine("conversion failed");
        }


            Console.ReadKey();

    }
}
