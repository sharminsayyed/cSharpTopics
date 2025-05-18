class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        // when we call the class for execution in main method for the first time at that only the static constructor is called and executed only once 
        Employee e2 = new Employee(2 , "sharmin","manager");
        Employee e3 = new Employee(3, "laxmi");

        // object intailizers usage 
        Employee e4 = new Employee() { enm = "sharmin", ejob = "executive" };

        Console.WriteLine("employee 1:");
        Console.WriteLine(e1.eid);
        Console.WriteLine(e1.enm);
        Console.WriteLine(e1.ejob);
        Console.WriteLine(Employee.companynm);
        Console.WriteLine();
        Console.WriteLine("employee 2:");
        Console.WriteLine(e2.eid);
        Console.WriteLine(e2.enm);
        Console.WriteLine(e2.ejob);
        Console.WriteLine(Employee.companynm);
        Console.WriteLine();
        Console.WriteLine("employee 3:");
        Console.WriteLine(e3.eid);
        Console.WriteLine(e3.enm);
        Console.WriteLine(e3.ejob);
        Console.WriteLine(Employee.companynm);

        Console.ReadKey();
    }
}