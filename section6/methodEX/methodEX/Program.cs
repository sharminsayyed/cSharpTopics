
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
        Product p1, p2, p3 ,p4,p5,p6;

        // objects
        p1 = new Product();
        // use of static method
        Product.SetNoOfProducts(Product.GetNoOfProducts() + 1); // 1

        p2 = new Product();
        // use of static method
        Product.SetNoOfProducts(Product.GetNoOfProducts() + 1); // 2

        p3 = new Product();
        // use of static method
        Product.SetNoOfProducts(Product.GetNoOfProducts() + 1); // 3

        p4 = new Product(); 
        p5 = new Product();
        p6 = new Product();

        //intailize feilds here using the set method
        p1.SetId(1001);
        p1.SetName("Mobile") ;
        p1.SetCost(20000);
        p1.SetQuantity(1200);

        p2.SetId(1002);
        p2.SetName("Laptop");
        p2.SetCost(45000);
        p2.SetQuantity(2300);

        p3.SetId(1003);
        p3.SetName("speaker");
        p3.SetCost(23000);
        p3.SetQuantity(1400);

        p4.SetId(1004);
        p4.SetName("mouse");
        p4.SetCost(12000);
        p4.SetQuantity(1390);

        p5.SetId(1005);
        p5.SetName("keyboard");
        p5.SetCost(1200);
        p5.SetQuantity(1220);

        p6.SetId(1005);
        p6.SetName("monitor");
        p6.SetCost(1400);
        p6.SetQuantity(1000);

        // call methods 
        p1.calTax(percentage :3.4); // usage of named argument - used when to many paramteres are there / and which value is passed to which parameter we specify the name of the parameter

        p2.calTax(10000, 3.4); // method overloading usage

        p3.calTax(); // here we used default parameter value

        double per1 = 10.5; // argument should be varaible and must be intialized
        p4.calTax1(ref per1);// usage of ref keyword
        Console.WriteLine("the value of  p is (ref) :"+per1);// value will be changed

        double per2;// argument must be a varaible but can be un-intailiazed
        p5.calTax2(out per2); // usage of out keyword
        // p5.calTax(out double per) // in c# 7.0
        Console.WriteLine("the value of  p is (out) :"+per2); //value will be passed by the parameter 

        double per3 = 12.2;
        p6.calTax3(in per3);//usage of in keyword - here this value cannot be changed /modified
        Console.WriteLine("the value of p is (in) :"+per3); // value remains same as we passed


        //  get values using the get method
        Console.WriteLine("product 1 id : " + p1.GetId());
        Console.WriteLine("product 1 name  :" + p1.GetName());
        Console.WriteLine("product 1 cost :" + p1.GetCost());
        Console.WriteLine("product 1 qauntity in stock : " + p1.GetQuantity());
        Console.WriteLine("date of purchase  : " + p1.GetDateOfPurcahse());
        Console.WriteLine("product 1 tax :"+p1.GetTax());

        Console.WriteLine("product 2 id : " + p2.GetId());
        Console.WriteLine("product 2 name  :" + p2.GetName());
        Console.WriteLine("product 2 cost :" + p2.GetCost());
        Console.WriteLine("product 2 qauntity in stock : " + p2.GetQuantity());
        Console.WriteLine("date of purchase  : " + p2.GetDateOfPurcahse());
        Console.WriteLine("product 2 tax :" + p2.GetTax());

        Console.WriteLine("product 3 id : " + p3.GetId());
        Console.WriteLine("product 3 name  :" + p3.GetName());
        Console.WriteLine("product 3 cost :" + p3.GetCost());
        Console.WriteLine("product 3 qauntity in stock : " + p3.GetQuantity());
        Console.WriteLine("date of purchase  : " + p3.GetDateOfPurcahse());
        Console.WriteLine("product 3 tax :" + p3.GetTax());

        int totalQuantity = Product.TotalQuantity(p1,p2,p3);
        Console.WriteLine("total quantity :"+totalQuantity);

        Console.WriteLine("total no of products : " + Product.GetNoOfProducts()); // use of static method
        Console.WriteLine("category name : " + Product.ctegoryName);
        Console.ReadKey();
    }
}