public class Salesman : IEmployee
{
    // feilds
    private string reg;
    // property 
    public string Region { set { reg = value; } get { return reg; } }

    // private fields for interface properties
    private int eid;
    private string enm;
    private string eloc;

    // implement the properties
    public int Empid
    {
        set
        {
            if (value >= 500 && value < 1000)
            {
                eid = value;
            }
        }
        get
        {
            return eid;
        }
    }
    public string Empname { set { enm = value; } get { return enm; } }
    public string Emploc { set { eloc = value; } get { return eloc; } }

    // constructor child class 
    public Salesman() { }

    public Salesman(int eid, string enm, string eloc, string reg) 
    {
        this.eid = eid;
        this.enm = enm;
        this.eloc = eloc;
        this.reg = reg;
    }

    // implementation of the method from the interface 
    // no need to write the override keyword 
    //step 2 

    public  string GetHealthInsuranceAmt()
    {
        return "health insurance amt is :500";
    }
    


}