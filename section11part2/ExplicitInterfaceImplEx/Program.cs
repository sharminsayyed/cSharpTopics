using System;

interface Interface1
{
    // method is public can be accessed by interface1
    void Move();
}

interface Interface2
{
    // method is public can be accessed by interface2
    void Move();
}

class ChildCLass :Interface1, Interface2
{
    // public is not allowed bydefault explicit interface implementation is private
    void Interface1.Move()
    {
        Console.WriteLine("move sharmin");
    }

    void Interface2.Move()
    {
        Console.WriteLine("move laxmi");
    }
}
// the child class reference varaible cannot access the methods (explicit interface implementation)
// beacuase these methods are by default private 
// but the reference varaible of corresponding interface can access there methods only
// because there methods are by default are public

class Program
{
    static void Main()
    {
        Interface1 i1 = new ChildCLass();
        i1.Move();

        Interface2 i2 = new ChildCLass();
        i2.Move();

        //ChildCLass c = new ChildCLass();
        //c.Move();  this will give error 

        Console.ReadLine();
    }
}