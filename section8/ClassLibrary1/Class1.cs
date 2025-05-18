using System.Runtime.Serialization;

public class Employee
{
    public int eid; // instance field
    public string enm;
    public string ejob;

    public static string companynm; // static field

    // implicit constructor  - created by c# compiler when the class does not have a constructor
    // does not intialize value -  and cannot be seen 
    // if the developer provides a constructor than implicit constructor is not formed 

    // below are explicit constructors 
    // below are example of constructor overloading 
    //  instance constructor - empty/parameter-less/default
    public Employee()
    {
        eid = 1;
    }

    // instance parameterized constructor 
    public Employee(int eid , string enm ,string ejob)
    {
        this.eid = eid;
        this.enm = enm;
        this.ejob = ejob;

    }
    public Employee(int eid , string enm)
    {
        this.eid = eid;
        this.enm = enm;
    }
    // static constructor - public by default , cannot have parameter , no return value
    static Employee()
    {
        // intialize static field
        companynm = "tatacs";
    }
}