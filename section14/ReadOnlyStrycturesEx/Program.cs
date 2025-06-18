class Program
{
    static void Main()
    {
        // create a instance of readonly structure 
        Marvel m;
        m = new Marvel("sharmin");

        // invoke the properties and methods 
        Console.WriteLine(m.Characternm);
        m.PrintCharacterName();


        Console.ReadKey();

    }
}