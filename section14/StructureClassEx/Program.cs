class Program
{
    static void Main()
    {
        // create structure instance 
        Structure1 s1;
        s1.x = 10;
        s1.y = 20;



        // create structure instance 2
        Structure1 s2;

        //copy data from structure 1 to struture 2
        s2 = s1;

        // modify data of structure 2
        s2.x = 100;
        s2.y = 200;

        // print the value 
        Console.WriteLine(s1.x); //10 , 20 ,100 ,200 
        Console.WriteLine(s1.y);
        Console.WriteLine(s2.x);
        Console.WriteLine(s2.y);

        // repeat same for classes 

        // create object1 based on class 
        Class1 c1;
        c1 = new Class1();
        c1.x = 10;
        c1.y = 20;

        // create object2 based on class
        Class1 c2;

        // copy reference from object 1 to object 2
        c2 = c1;

        // modify data of object 2
        c2.x = 100;
        c2.y = 200;

        // print the value 
        Console.WriteLine();
        Console.WriteLine(c1.x);// 100 , 200 ,100 ,200 
        Console.WriteLine(c1.y);
        Console.WriteLine(c2.x);
        Console.WriteLine(c2.y);


        // from we understand that 
        // since structure are value type the data has been copies to the new structure instance and values are overwritten in new structure instance 
        // but in classes  since classes are reference type when u assign values that data have been overwritten in the object so the same can be accessible by first reference varaible(c1) or second reference varaible (c2)

        Console.ReadKey();

    }
}