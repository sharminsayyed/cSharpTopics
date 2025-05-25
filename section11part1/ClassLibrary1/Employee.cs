
// abstract class cannot be instantiated - means cannot have an object 
// abstract class act as parent class which should be inherited by the child class 
// with the help of child class we can access all the members of abstract class

public  abstract class Employee
{
    
    private int eid;
    private string enm;
    private string eloc;

    public Employee() { }
    
    
    public Employee(int eid , string enm , string eloc)
    {
        this.eid = eid;
        this.enm = enm;
        this.eloc = eloc;
    }


    public int Empid { set { eid = value; } get { return eid; } }
    public string Empname { set { enm = value; } get { return enm; } }
    public string Emploc { set { eloc = value; } get { return eloc; } }

    // abstract method only provide the method decclaration /signature 
    // the child classes should provide implementation to these methods 
    // step 1 
    public  abstract  string GetHealthInsuranceAmt();
    
    // when we use virtual keyword we have extends the parent class method in child class 
    // when we use abstract keyword the child classes have to implement the parent class method 


    // abstract class can create both abstract methods and virtual methods 
    public virtual string GetSalary()
    {
        return "Employee salary is :9000";
    }

    //sealed methods 
    public virtual string GetTax()
    {
        return "employee tax is 2399";
    }
}