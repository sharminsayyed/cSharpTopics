public class Salesman : Employee
{
    // feilds
    private string _reg;

    // constructor child class 
    public Salesman() { }
    // can call the constructor of parent class 

    // here in the constructor of child class we have also passed the parameter for the parent class constructor  so that when child class constructor is called it calls the parent class constructor to  assign the value to parent class feilds and then assigns value to child class (parent class constructor executes first and then child class constructor )
    public Salesman(int eid, string enm, string eloc ,string reg) : base(eid, enm, eloc)
    {
        _reg = reg;
    }
    // property 
    public string Region { set { _reg = value; } get { return _reg; } }

    // method
    public long GetSalesOfTheCurrentMonth()
    {
        return 100;
    }

    // as the method overriding is not compulsory 
    // so the virtual method can be and cannot be override by the child class 

}