
using static System.Console;
class Program
{
    static void Main()
    {
        // wecannot create object / instance of static class 
        //Country c = new Country();

        //  access static  members of static class 
        WriteLine(Country.name);
        WriteLine(Country.noOfStates);
        WriteLine(Country.GetNoOUnionTerritories());

        ReadKey();
    }
}