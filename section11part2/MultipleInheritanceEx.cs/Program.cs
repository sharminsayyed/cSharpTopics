class Program
{
    static void Main()
    {
        // creating reference varaible of type interfaces and object of child class is assigned 
        IEmployee emp;
        emp = new Manager(2, "anuskha", "kolkata", "banking");
        // here emp reference varaible can only access the method from the IEmployee interface 
        Console.WriteLine(emp.GetHealthInsuranceAmt()); 
        Console.WriteLine();

        IPerson per;
        per = new Manager(3, "avantika", "delhi", "wanwori");
        // here per reference varaible can only access the method and properties from the IPerson interface 
        per.DateOfBirth = System.Convert.ToDateTime("2004-09-02");
        Console.WriteLine(per.GetAge());
        Console.WriteLine();

        // the child class with mutiple interfaces (mutiple inheritance ) can access both the methods 
        // from both the interfaces
        Manager c1 = new Manager(4, "laxmi", "mumbai", "panvel");
        c1.DateOfBirth = System.Convert.ToDateTime("2004-09-02");
        Console.WriteLine(c1.GetAge());
        Console.WriteLine(c1.GetHealthInsuranceAmt());

        Console.ReadLine();
    }
}