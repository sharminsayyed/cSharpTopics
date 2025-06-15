
using static System.Console;
using WareHouese;
class Program
{
    static void Main()
    {
        // each partial class can be developed individually , by different developers /teams 
        // create an object of partial class 
        Product p = new Product();

        //access properties and methods which are defines in multiple files 
        p.Cost = 1000;
        p.Pid = 23;
        WriteLine(p.Cost);
        WriteLine(p.Pid);
        p.CallPartialMethod();

        ReadKey();
    }
}