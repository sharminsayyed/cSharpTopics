class Program
{
    static void Main()
    {
        Car c = new Car();
        Console.WriteLine(c[0]); // with the help of indexers we can access aand set the value to a particular ele in array or strings
        Console.WriteLine(c["first"]);

        c[0] = "tata punch";
        Console.WriteLine(c[0]);
        Console.WriteLine(c["first"]);


        Console.ReadKey();
    }
}