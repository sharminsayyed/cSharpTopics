using System.Dynamic;

class Program
{
    static void Main()
    {

        // child classes 
        // child class can access the fields and methods of abstract parent class 


        Manager m1 = new Manager(2, "anuskha", "kolkata", "banking");
        Console.WriteLine("object of child class manager :");
        Console.WriteLine(m1.Empid);
        Console.WriteLine(m1.Empname);
        Console.WriteLine(m1.Emploc);
        Console.WriteLine(m1.Dept);
        Console.WriteLine(m1.GetHealthInsuranceAmt()); // step 3 -interface method calling by the child class object 
        Console.WriteLine();

        Salesman s1 = new Salesman(3, "avantika", "delhi", "wanwori");
        Console.WriteLine("objects of child class salesman :");
        Console.WriteLine(s1.Empid);
        Console.WriteLine(s1.Empname);
        Console.WriteLine(s1.Emploc);
        Console.WriteLine(s1.Region);
        Console.WriteLine(s1.GetHealthInsuranceAmt());// step 3 - interface calling by the child class object
        Console.WriteLine();


        Console.ReadKey();
    }
}