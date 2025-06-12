class Program
{
    static void Main()
    {
        // creating reference varaible of type interfaces and object of child class is assigned 

        // reference varaible of parent interface 
        IPersonParentInterface per;
        per = new Manager(2, "anuskha", "kolkata", "banking");
        // with this we will only be able to access the members of parent interface only 
        per.DateOfBirth = System.Convert.ToDateTime("2004-09-02");
        Console.WriteLine(per.GetAge()) ;

        // reference varaible of child interface which implements the parent interface 
        IEmployeeChildInterface emp;
        emp = new Manager(3, "avantika", "delhi", "wanwori");
        // with the help of child interfaces we can access member of both parent interface and child interface both 
        Console.WriteLine(emp.GetHealthInsuranceAmt()); // child interface method 
        emp.DateOfBirth = System.Convert.ToDateTime("2004-09-02"); 
        Console.WriteLine(emp.GetAge());// parent interface method 

        Console.ReadLine();
    }
}