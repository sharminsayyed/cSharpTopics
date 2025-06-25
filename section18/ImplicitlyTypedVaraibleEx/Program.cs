
using Namespace1;
using System.Xml.Linq;
namespace ImplicitlyTypedVaraible
{
    class Program
    {
        static void Main()
        {
            // here we have to write a long path of the class 
            //Namespace1.Namespace2.Namespace3.Person p;
            // so instead we can use var keyword which is implicitly typed varaible 
            // here the c# compiler automatically identifies the datatype at compilation time based on the value assigned at the time of declaration
            var p = new Namespace1.Namespace2.Namespace3.Person() { PersonName = "sharmin" };
            Console.WriteLine(p.PersonName);

            //var p2 ; it is wrong if u do not intailize the var varaible it will be a compile time error 
            var p2 = "sharmin".ToUpper();
            Console.WriteLine(p2);

            // datatype cannot be changed in later statements once its fixed 
            // datatype is fixed the value is not fixed 
            p.PersonName = "laxmi";
            Console.WriteLine(p.PersonName);
            Console.ReadKey();

            //While declaration, the 'type' of implicitly-typed variables is fixed. It is not possible to change the type of that variable or assign "other type of values" into the implicitly typed variables, after declaration.

            //Implicitly Typed Variables can only be "local variables"; can't be used for method parameters, return type or fields.

            //Implicitly Typed Variables must be initialized along with declaration.

            //It is not possible to declare multiple implicitly typed variables in the same statement.Eg: var x = 10, y = 20; //error

            //It is not possible to assign "null" into implicitly typed variables(while declaration).Eg: var x = null; //error




        }
    }
}