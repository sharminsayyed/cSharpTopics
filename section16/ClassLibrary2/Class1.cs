// generic constraints 
//A generic constraint in C# is a restriction you apply to a type parameter in a generic class, method, or interface that specifies what kinds of types are allowed to be used with that parameter.
//By default, a generic type like <T> can be any type — class, struct, interface, etc.
//Constraints let you:
//Access specific members (e.g., new() constructor, interface methods)

//Ensure type safety at compile time

//Use only appropriate types

using System.Reflection.Metadata;

public abstract class Student
{
    public abstract int Marks { set; get; }
}

// child classes of student 
public class UGstudent : Student
{
    public override int Marks { set; get; }
}

public class PGstudent : Student
{
    public override int Marks { set; get; }
}

// generic class with constraint that says only student or its child classes type parameter will be accepted 
// for multiple generic constraints 
//public class Classname <T1, T2> where T1 :class where T2 : struct { }
public class MarkPrinter <T> where T : Student
{
    public T student;

    public void PrintMarks()
    {
        Console.WriteLine(student.Marks);
    }
}