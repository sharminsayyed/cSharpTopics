// class library to define all the classes here  dll files - assembly 
public class Product
{
    // fields 
    public int id;
    public string name;
    public double cost;
    public int quantityInStock;
    public static int totalNoOfProd;
    public const string ctegoryName = "electronics";
    public readonly string dateOfPurchase;

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}


public class program
{
    public static void Main(string[] args) { 
    }
}