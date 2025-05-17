/*
 You have the following values to convert:

byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
int b = 10; //Convert this value into "short" type (assign into another short type of variable)
string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
decimal d = 20.3; //Convert this value into "string" type (assign into another string type of variable)
And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.*/

using System;

class Program
{
    static void Main()
    {
        //1 - implicit casting - lower to higher
        byte a = 10;
        short a1 = a;
        Console.WriteLine( a1);

        //2 - explicit casting - higher to lower 
        int b = 10;
        short b1 = (short)b;
        Console.WriteLine(b1);

        //3 - parse and tryparse(most used)
        string c = "10.34";
        double c1 = double.Parse(c);
        Console.WriteLine(c1);
        bool bol = decimal.TryParse(c, out decimal c2);
        if (bol)
        {
            Console.WriteLine(c2);
        }
        else
        {
            Console.WriteLine("not converted");
        }


        //4 - -conversion method
        decimal d =20.3m ;
        string d1 = Convert.ToString(d);
        Console.WriteLine(d1);


        Console.ReadKey();

    }
}