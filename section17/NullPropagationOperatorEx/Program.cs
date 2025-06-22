namespace NullPropagationOperator
{

    class Person
    {
        public int age;
    }
    class Program
    {
        static void Main()
        {
            Person p1=null; // class is nullable type by default 
            Person p2 = new Person() { age = 34 };
            // usage of null propagation operator 
            // syntax - reference varaible ?. feildname 
            // checks if the reference varaible is null or not 
            // if null then returns null 
            // if not null then return the feildname , method ,property for that reference varaible
            // It accesses the property or method, only if the reference variable is "not null"; just returns "null", if the reference variable is "null".
            //Advantage: We can invoke desired member (property or method) after checking if null.
            Console.WriteLine(p1?.age);
            Console.WriteLine(p2?.age);

            // what the above statement means 
            //Console.WriteLine((p1 == null) ? null: Convert.ToString(p1.age)) ;
            //Console.WriteLine((p2 == null) ? null : Convert.ToString(p2.age));


            Console.ReadKey();
        }
    }
}