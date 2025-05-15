
using System;

    // console application - exe file - assembly 

class Sample
{
   public static void Main(string[] args)
    {
        // local constant 
        const string namee = "sharmin";
        Console.WriteLine(namee);
        // create reference varaible 
        Product p1, p2, p3;
       
        // objects
        p1 = new Product();
        // static feilds
        Product.totalNoOfProd++;

        p2 = new Product();
        Product.totalNoOfProd++;

        p3 = new Product();
        Product.totalNoOfProd++;

        //intailize feilds 
        p1.id = 1001;
        p1.name = "Mobile";
        p1.cost = 20000;
        p1.quantityInStock = 1200;

        p2.id = 1002;
        p2.name = "Laptop";
        p2.cost = 45000;
        p2.quantityInStock = 2300;

        p3.id = 1003;
        p3.name = "Speaker";
        p3.cost = 23000;
        p3.quantityInStock = 1400;

        //  get values from thefeilds 
        Console.WriteLine("product 1 id : "+p1.id);
        Console.WriteLine("product 1 name  :" +p1.name);
        Console.WriteLine("product 1 cost :"+p1.cost);
        Console.WriteLine("product 1 qauntity in stock : "+p1.quantityInStock);
        Console.WriteLine("date of purchase  : "+p1.dateOfPurchase);

        Console.WriteLine("product 2 id : "+ p2.id);
        Console.WriteLine("product 2 name  :" + p2.name);
        Console.WriteLine("product 2 cost :" + p2.cost);
        Console.WriteLine("product 2 qauntity in stock : " + p2.quantityInStock);

        Console.WriteLine("product 3 id : " + p3.id);
        Console.WriteLine("product 3 name  :" + p3.name);
        Console.WriteLine("product 3 cost :" + p3.cost);
        Console.WriteLine("product 3 qauntity in stock : " + p3.quantityInStock);
        Console.WriteLine("total no of products : "+Product.totalNoOfProd);
        Console.WriteLine("category name : " + Product.ctegoryName);
        Console.ReadKey();
    }
}