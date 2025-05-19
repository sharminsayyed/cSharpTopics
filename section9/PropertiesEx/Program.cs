class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        e1.EmpId = 101; // assign value to the property 
        e1.EmpNm = "sharmin";
        e1.EmpJob = "manager";
        e1.EmpTax = 700; // write only property - only sets the value 
        e1.NativePl = "pune"; // automated implemented property
        Employee.CompanyNm = "tcs";
        // in constructor we cannot use the properties as we directly intialize value to the feilds 
        Employee e2 = new Employee(202, "laxmi", "clerk");
        // we can use properties in object intailizers
        Employee e3 = new Employee() { EmpId = 102, EmpNm = "priya", EmpJob = "clerrkk" };

        // to get value of feilds use properties 

        Console.WriteLine("employee 1:");
        Console.WriteLine(e1.EmpId);
        Console.WriteLine(e1.EmpNm);
        Console.WriteLine(e1.EmpJob);
        Console.WriteLine(e1.Empsal); // read-only property - only get the value 
        Console.WriteLine(e1.NativePl); //  automated implemented property
        Console.WriteLine(Employee.CompanyNm);
        Console.WriteLine();
        Console.WriteLine("employee 2:");
        Console.WriteLine(e2.EmpId);
        Console.WriteLine(e2.EmpNm);
        Console.WriteLine(e2.EmpJob);
        Console.WriteLine(e2.Empsal); // read-only property - only get the value 
        Console.WriteLine(e2.NativePl); //  automated implemented property
        Console.WriteLine(Employee.CompanyNm);
        Console.WriteLine(); 
        Console.WriteLine("employee 3:");
        Console.WriteLine(e3.EmpId);
        Console.WriteLine(e3.EmpNm);
        Console.WriteLine(e3.EmpJob);
        Console.WriteLine(e3.Empsal); // read-only property - only get the value 
        Console.WriteLine(e3.NativePl); //  automated implemented property
        Console.WriteLine(Employee.CompanyNm);
        Console.WriteLine();

        Console.ReadKey();
    }
}