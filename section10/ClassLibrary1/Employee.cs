// parent class
// if after public u write sealed keyword than the employee class will be a  sealed class 
// sealed classes cannot be inherited - so manager and salemans class cannot inherit the employee class 
// sealed class cannot allow virtual methods (override) and abstract methods 

public  class Employee
{
    // normal class cannot have abstract methods 
    // fields
    private int eid;
    private string enm;
    private string eloc;

    public Employee() { }
    
    //constructor of parent class 
    // can be called in child class if is parameterized constructor 
    public Employee(int eid , string enm , string eloc)
    {
        this.eid = eid;
        this.enm = enm;
        this.eloc = eloc;
    }


    // properties declared here - private feilds will automatically will be created by the compiler 
    // public string Emploc { set; get; }
    public int Empid { set { eid = value; } get { return eid; } }
    public string Empname { set { enm = value; } get { return enm; } }
    public string Emploc { set { eloc = value; } get { return eloc; } }

    // method hiding usage 
    // parent class method is hidden by the child class
    // so the parent class will not be executed 
    public string GetHealthInsuranceAmt()
    {
        return " health insurance amount is :" + 500;
    }

    //method overriding 
    // here the parent class method is override by the child class method 
    public virtual string GetSalary()
    {
        return "Employee salary is :9000";
    }

    //sealed methods 
    // this is a parent class which will be overriden by the child class 
    public virtual string GetTax()
    {
        return "employee tax is 2399";
    }
}