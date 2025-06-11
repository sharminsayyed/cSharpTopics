// polymorphism means many form
// compile time and runtime are 2 types 
// compile time is also called as early binding and static poly
// runtime is also called as late binding and dynamic poly
// dynamic poly can be implemented using abstract class and interfaces 

// using abstract classes 
abstract class ParentClass
{
    // step 1 - create abstract method in abstract class
    public abstract void Display();
}

// step 2 - implement abstract method in childclasses 
class ChildClass1 : ParentClass
{
    public override void Display()
    {
        Console.WriteLine("hello");
    }
}
class ChildClass2 : ParentClass
{
    public override void Display()
    {
        Console.WriteLine("hi");
    }
}

class Program
{
    static void Main()
    {
        // abstract class
        // step 3 - create reference varaible of abstract class  
        ParentClass p;
        //step 4 - assign the reference varaible to the object of childclass1 or 2 
        p = new ChildClass1();
        // step 5 - call the abstract method through the reference varaible of the abstract class 
        p.Display(); // ChildClass1.Display()

        //step 4 - assign the reference varaible to the object of childclass1 or 2 
        p = new ChildClass2();
        // step 5 - call the abstract method through the reference varaible of the abstract class 
        p.Display();// ChildClass2.Display()


        // interfaces -- very similar to abstract class 
        IParentClass ip;

        ip = new Child1();
        ip.GreetFriend();

        ip = new Child2();
        ip.GreetFriend();

        Console.ReadLine();

    }
}

// using interfaces

interface IParentClass
{
    void GreetFriend();
}

class Child1:IParentClass
{
    public void GreetFriend()
    {
        Console.WriteLine("hello sharmin");
    }
}

class Child2 : IParentClass
{
    public void GreetFriend()
    {
        Console.WriteLine("hi laxmi");
    }
}
