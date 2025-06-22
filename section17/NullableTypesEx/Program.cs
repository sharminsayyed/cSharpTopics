namespace Namespace1
{
    class Person
    {
        // structure , enumeration are value types 
        // which are by default non nullable types (cannot assign null value)
        public int? noOfchildren; // converted value type to nullable type
        //public Nullable<int> noofchilren; another syntax
    }
    class Program
    {
        static void Main()
        {
            Person p1= new Person() { noOfchildren = 2 };
            Person p2 = new Person() { noOfchildren = 34 };// for if statement
            Person p3 = new Person() { noOfchildren = 12 }; // for ternary condition
            Person p4 = new Person() { noOfchildren = null }; // for null coalescing opertor 
            Person p5 = new Person() { noOfchildren = null }; // to show blank output
            Person p6 = null; // reference types are by default nullable types (can assign null value)
            // reference types include interfaces , classes


            Console.WriteLine(p1.noOfchildren);

            // we can use if statement to chaeck if the value is null or not 
            // if(p2.noOfcildren != null)
            if (p2.noOfchildren.HasValue)
            {
                int x = p2.noOfchildren.Value; // use Value to access the actual value which is inside the nullable type 
                Console.WriteLine(x);
            }

            // we can also use ternary operator 
            Console.WriteLine((p3.noOfchildren.HasValue) ?p3.noOfchildren.Value :0);

            // usage of null coalescing operator 
            // help us to avoid the usage of if statement to check if it is null or not 
            // syntax :varaible ?? valueIfNull
            // if not null leftside value will be displayed if null right side value will be display 
            Console.WriteLine(p4.noOfchildren ?? -1);


            Console.WriteLine(p5.noOfchildren); // it is null will give a blank output 

            Console.ReadKey();
        }
    }
}