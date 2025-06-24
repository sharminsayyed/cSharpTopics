
using ClassLibrary2;
namespace PatternMatchingEx
{
    class Program
    {
        static void Main()
        {
            // reference varaible of parent class 
            ParentClass p;

            // object of child class 
            p = new ChildClass() { x = 2, y = 3 };
            // p = new ParentClass(){x=2}; try this also the if will not execute 

            // parent class reference varaible cannot access the members of child class 
            Console.WriteLine(p.x);
            //Console.WriteLine(p,y); error 

            // the reference varaible is assigned to the obj of child class 
            // if yes than covert that same object (parent class reference varaible) to child class reference varaible 
            // this is pattern matching = converting parent class reference varible to child class RV
            if(p  is ChildClass c)
            {
                Console.WriteLine(c.y); // child class property 
                Console.WriteLine(c.x); // parent class property
            }

            // it is a simplified syntax to perfom multiple checks of data types and type casts 
            Console.ReadKey();
        }
    }
}