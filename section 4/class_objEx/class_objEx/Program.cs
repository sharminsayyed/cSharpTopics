using System.Runtime.Remoting;

// it is a console application it it not important to have internal or public class
public class Sample
{
   static void Main()
    {
        Customer c1 , c2; // these are reference varaible (local varaible) - stores reference of object stored in stack 
        // objects are stored in heap memory 
        c1 =new Customer();
        c2 = new Customer();

    }
}