 public class Manager : Employee
{
    // feilds
    private string _dept;

    // constructor child class 
    public Manager() { }
    // can call the constructor of parent class 

    
    public Manager(int eid, string enm, string eloc ,string dept):base(eid,enm,eloc)
    {
        this._dept = dept;
    }

    public string Dept { set { _dept = value;  } get { return _dept; } }

   
    // abstract class method is implemented here in the child class 
    //step 2 
    public override string GetHealthInsuranceAmt()
    {
        return "health insurance amt is :1500";
    }

    // method overriding 
    public override string GetSalary()
    {
        string s = base.GetSalary(); // base keyword is impt to call the parent class method 
        Console.WriteLine(s);
        return "here manager  salary is : 16000";

    }

    // sealed methods 
    public sealed override string GetTax()
    {
        string s = base.GetTax();
        Console.WriteLine(s);
        return "manager tax  :89999";

    }
    // methods 
    public long GetTotalSalesOfTheYear()
    {
        return 100;
    }

    public string GetFullDeptName()
    {
        return Dept + " at " + base.Emploc; // usage of base keyword to access the parent class members 
        // such as feilds , methods , properties 
    }
}

