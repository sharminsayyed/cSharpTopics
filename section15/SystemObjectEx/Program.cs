using System.Xml;

class Program
{
    static void Main()
    {
        // create object of person class 
        // here we assign child class object to parent class reference varaible 
        System.Object o1 = new Person() { Pemail = "sharmin@gmail.com", Pname = "sharmin" };

        // access methods of System.Oject class by using the reference varaible of System.Oject class

        // receives another value of System.object type and returns true if both are equal and also returns false if both are not equal 
        // this method can be overriden to implement ur own logic  while comparing 2 objects 

        //Compares the current object with the given argument object; returns true, if both are same objects; returns false, if both are different objects.

        // here the override method will be called
        Console.WriteLine(o1.Equals(new Person() { Pemail="sharmin@gmail.com" , Pname ="sharmin"}));


        // this method returns an HashCode that is a numerical value that is used to verify whether 2 objects are same or not .
        // we call the gethashcode for both obj and compare the return value of  gethashcode  method if they are different it means that they are different objects 
        // mainly used for hashtable , collection 

       // Returns the a number that represents the object.It is not guarantee that the hash code is unique, by default.
        //can be override 
        Console.WriteLine(o1.GetHashCode());

        // method return the type name (class name for which the object is created )
        //Returns the name of the class (including namespace path), based on which, the object is created.
        // this method cannot be overriden 
        Console.WriteLine(o1.GetType());

        // method return the type name (class name for which the object is created )
        //By default, it returns the name of the class (including namespace path), based on which, the object is created.
        // here the override method will be called 
        Console.WriteLine(o1.ToString());

        Console.ReadKey();
    }
}