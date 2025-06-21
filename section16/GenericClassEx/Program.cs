class Program
{
    static void Main()
    {
        // create an object of generic class 
        // here the class is same but datatypes used are different 
        // when u want to store different types of value with respect to various objects 
        // ypu decide the datatype of the feild while creating the object rather than while creating feild in the class 
        // helps in code reuse , performance , type safety 
        // we can create generic classes , interfaces methods and delegates 
        User<int,int > u1 = new User<int,int>();
        u1.registrationStatus = 21;
        u1.age = 23;
        Console.WriteLine(u1.registrationStatus);
        Console.WriteLine(u1.age);

        User<bool,string > u2 = new User<bool,string >();
        u2.registrationStatus = false;
        u2.age = "35 to 45";
        Console.WriteLine(u2.registrationStatus);
        Console.WriteLine(u2.age);

        Console.ReadLine();

    }
}