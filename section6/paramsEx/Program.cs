using System;

class Student
{
    // use of params keyword - to receive all the arguments passed and store it in an array
    public void DisplaySubjects(params string[] subjects)
    {
        for(int i =0; i< subjects.Length; i++)
        {
            Console.WriteLine(subjects[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        // pass arguments 
        // mainly params parameter modifier is used because when we dont know the number of arguments that can be passed to the method 
        s.DisplaySubjects("computer networks", "operating systems", "oops", "java programming", "android practical", "software engineering");

        Console.ReadKey();
    }
}