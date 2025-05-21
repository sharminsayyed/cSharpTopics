public class Manager : Employee
{
    // feilds
    private string _dept;

    // constructor child class 
    public Manager() { }
    // can call the constructor of parent class 

    // here in the constructor of child class we have also passed the parameter for the parent class constructor  so that when child class constructor is called it calls the parent class constructor to  assign the value to parent class feilds and then assigns value to child class (parent class constructor executes first and then child class constructor )
    public Manager(int eid, string enm, string eloc ,string dept):base(eid,enm,eloc)
    {
        this._dept = dept;
    }

    public string Dept { set { _dept = value;  } get { return _dept; } }

    // method hiding
    //here the child class hides the method of parent class using the new keyword 
    // with the object of child class we can only access this method not the parent class method 
    // so the parent class will not be executed 

    public new string GetHealthInsuranceAmt()
    {
        return "health insurance amt is :1500";
    }

    // method overriding 
    // here the child class method extends the parent class method 
    // parent class method executes first and then child class method executes when called by the object of child class 

    public override string GetSalary()
    {
        string s = base.GetSalary(); // base keyword is impt to call the parent class method 
        Console.WriteLine(s);
        return "here manager  salary is : 16000";

    }

    // sealed methods 
    // applicable on only overriden methods 
    // sealed means that this method will not be overriden if a child class inherites this particular class 
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

public class BranchManager : Manager
{
    public BranchManager(int eid, string enm, string eloc, string dept) : base(eid, enm, eloc)
    {
    }
    //public  override string GetTax() { } 
    // this class will not be able to inherits the sealed method 


}