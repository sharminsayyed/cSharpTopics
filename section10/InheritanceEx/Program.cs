class Program
{
    static void Main()
    {
        // parent class
        Employee e = new Employee();
        // with the help of parent class we cannot access the fields and methods of child class 
        e.Empid = 23;   e.Empname = "sharmin";   e.Emploc = "pune";
        Console.WriteLine("Object of parent class :");
        Console.WriteLine(e.Empid);
        Console.WriteLine(e.Empname);
        Console.WriteLine(e.Emploc);
        Console.WriteLine();

        // child classes 
        // child class can access the fields and methods of parent class 
        Manager m = new Manager();
        m.Empid = 24;  m.Empname = "laxmi";  m.Emploc = "mumbai";  m.Dept = "accounting";
        Console.WriteLine("object of child class manager :");
        Console.WriteLine(m.Empid);
        Console.WriteLine(m.Empname);
        Console.WriteLine(m.Emploc);
        Console.WriteLine(m.Dept);
        Console.WriteLine(m.GetTotalSalesOfTheYear());
        Console.WriteLine(m.GetFullDeptName());
        Console.WriteLine();

        Salesman s = new Salesman();
        s.Empid = 25; s.Empname = "iqra"; s.Emploc = "loni"; s.Region = "kondhwa";
        Console.WriteLine("objects of child class salesman :");
        Console.WriteLine(s.Empid);
        Console.WriteLine(s.Empname);
        Console.WriteLine(s.Emploc);
        Console.WriteLine(s.Region);
        Console.WriteLine(s.GetSalesOfTheCurrentMonth());
        Console.WriteLine();


        // usage of constructor to assign values to the feids 
        // ans see the connection of parent class constructor with child class constructor

        Employee e1 = new Employee(1, "divya", "banglore");
        Console.WriteLine("Object of parent class :");
        Console.WriteLine(e1.Empid);
        Console.WriteLine(e1.Empname);
        Console.WriteLine(e1.Emploc);
        Console.WriteLine();

        // here in the constructor of child class we have also passed the parameter for the parent class constructor  so that when child class constructor is called it calls the parent class constructor to  assign the value to parent class feilds and then assigns value to child class (parent class constructor executes first and then child class constructor )
        Manager m1 = new Manager(2, "anuskha", "kolkata", "banking");
        Console.WriteLine("object of child class manager :");
        Console.WriteLine(m1.Empid);
        Console.WriteLine(m1.Empname);
        Console.WriteLine(m1.Emploc);
        Console.WriteLine(m1.Dept);
        Console.WriteLine(m1.GetTotalSalesOfTheYear());
        Console.WriteLine(m1.GetFullDeptName());
        Console.WriteLine(m1.GetHealthInsuranceAmt()); // usage of method hiding 
        Console.WriteLine(m1.GetSalary()); // usage of method overriding 
        Console.WriteLine();

        Salesman s1 = new Salesman(3, "avantika", "delhi", "wanwori");
        Console.WriteLine("objects of child class salesman :");
        Console.WriteLine(s1.Empid);
        Console.WriteLine(s1.Empname);
        Console.WriteLine(s1.Emploc);
        Console.WriteLine(s1.Region);
        Console.WriteLine(s1.GetSalesOfTheCurrentMonth());
        Console.WriteLine();


        Console.ReadKey();
    }
}