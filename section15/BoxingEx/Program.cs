class Program
{
    static void Main()
    {
        // primitive varaible 
        int x = 10; // stored in stack memory

        // boxing -(value type datatype) to (reference type datatype)
        // boxing happens internally / automatically 
        // from stack memory to heap memory
        // no need of the syntax 
        //System.Object obj = x;
        object obj = x; // value copied in the heap memory

        Console.WriteLine(x);
        Console.WriteLine(obj);

        Console.ReadKey();
    }
}