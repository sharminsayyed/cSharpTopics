// class library to define all the classes here  dll(data link library) files - assembly 
using System.Globalization;

public class Product
{
    // fields 
    private int id;
    private string name;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int totalNoOfProd;
    public static int noOfProduct;
    public const string ctegoryName = "electronics";
    private readonly string dateOfPurchase;

    // set the readonly field
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    // method 
    public void calTax( double percentage =4.0) // usage of default parameter value- will be used if the parameter is not passed 
    {
        // usage of local varaible 
        double t;
        if (cost <= 20000)
            t = cost * 10 / 100;
        else
            t = cost * percentage / 100;
        tax = t;
    }
    // below methods are declared for showing the ex of parameter modifier
    public void calTax1( ref double percentage) // usage parameter modifier = ref 
    {
        //  chages are affected to argument 
        percentage = 20.90;
        double t;
        if (cost <= 20000)
            t = cost * 10 / 100;
        else
            t = cost * percentage / 100;
        tax = t;
    }
    public void calTax2(out double percentage) // usage parameter modifier = out
    {
        // here the value of the parameter is passed to the argument
        percentage = 12.90;
        double t;
        if (cost <= 20000)
            t = cost * 10 / 100;
        else
            t = cost * percentage / 100;
        tax = t;
    }

    public void calTax3(in double percentage) // usage parameter modifier = in
    {
        // here the value of the parameter cannot be modified -read only 
        //percentage = 12.90;
        double t;
        if (cost <= 20000)
            t = cost * 10 / 100;
        else
            t = cost * percentage / 100;
        tax = t;
    }

    // method overloading usage here 
    public void calTax( double cost ,double percentage)
    { // usage of default parameter modifier as no modifier is given to cost and percentage 
        // and change in the parameter will not affect the argument passed 
        double t;
        if (cost <= 20000)
            t = cost * 5 / 100;
        else
            t = cost * percentage / 100;
        tax = t;
    }
    // have the get and set methods where we can access the private fields inside the method  
    // we do like to hide the feilds etc and use in the public methods 
    public void SetId(int id) // usage of parameter 
    {
        // using the the this keyword becomes complusory when para and feild name is same
        this.id = id;
    }
    public int GetId() { return id; }

    public void SetName(string val)
    {
        name = val;
    }
    public string GetName() { return name; }

    public void SetCost(double val)
    {
        cost = val;
    }
    public double GetCost() { return cost; }
    public double GetTax() { return tax; }

    public void SetQuantity(int val)
    {
        quantityInStock = val;
    }
    public int GetQuantity() { return quantityInStock; }

    public string GetDateOfPurcahse() { return dateOfPurchase; }

    // create a static method to manipulate static fields
    public static void SetNoOfProducts(int val) 
    {
        
       noOfProduct = val;
    }
    public static int GetNoOfProducts() { return noOfProduct; }

    // reference varaible (object) passed as parameter 
    // static method 

    public static int TotalQuantity(Product p1 , Product p2 , Product p3)
    {
        return p1.GetQuantity() + p2.GetQuantity() + p3.GetQuantity();
    }

}


public class program
{
    public static void Main(string[] args)
    {
    }
}