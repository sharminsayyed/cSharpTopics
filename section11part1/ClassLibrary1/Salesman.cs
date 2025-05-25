public class Salesman : Employee
{
    // feilds
    private string _reg;

    // constructor child class 
    public Salesman() { }
    // can call the constructor of parent class 

    
    public Salesman(int eid, string enm, string eloc ,string reg) : base(eid, enm, eloc)
    {
        _reg = reg;
    }
    // property 
    public string Region { set { _reg = value; } get { return _reg; } }

    // abstract class method is implemented here in the child class 
    //step 2 

    public override string GetHealthInsuranceAmt()
    {
        return "health insurance amt is :500";
    }
    // method
    public long GetSalesOfTheCurrentMonth()
    {
        return 100;
    }


}