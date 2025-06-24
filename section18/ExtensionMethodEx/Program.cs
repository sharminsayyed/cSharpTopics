using ClassLibrary1;
using ExtensionMethodEx;

class Program
{
    static void Main()
    {
        // create an object of target class 
        Product p = new Product();
        // using the reference varaible of target class we call the extension method which is declared and defined in another class (static class) where as this method is injected / added in product class without modifying the product class 

        double res = p.GetDiscount();
        Console.WriteLine(res);

        Console.ReadKey();

    }
}