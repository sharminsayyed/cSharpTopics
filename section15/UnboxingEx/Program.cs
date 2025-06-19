class Program
{
    static void Main()
    {
        // reference type value 
        //System.Object obj = 10;
        object obj = 10; // stored in heap memory 

        // unboxing - reference type datatype to value type datatype 
        // from heap memory to stack memory 

        int x = (int)obj; // value copied in stack memory  now 

        Console.WriteLine(obj);
        Console.WriteLine(x);

        Console.ReadKey();
    }
}