using System;
using System.Runtime.Remoting.Messaging;

class Student
{
    public int grade = 2;

    public void showgrade()
    {
        Console.WriteLine("grade :"+grade);
    }

    // usage of ref returns
    public ref int change()
    {
        // returning reference to the grade varaible
        return ref grade;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.showgrade();

        // get the reference of the varaible from the ref method
        ref int  g = ref s.change();

        // the changes in g will also be seen in the grade because we have passed the reference 
        g = 90;

        // printing grade after changing the reference varaible 
        s.showgrade();

        Console.ReadKey();

    }
}