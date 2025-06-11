// 
// child class should implement the properties and methods from the interface 
public class Manager : IEmployee

{
    // feilds
    private string dept;
    public string Dept { set { dept = value; } get { return dept; } }

    // private fields for interface properties
    private int eid;
    private string enm;
    private string eloc;

    // implement the properties
    public int Empid
    {
        set
        {
            if (value >= 1000 && value <= 2000)
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
    public Manager() { }

    // can call the constructor of parent class 
    public Manager(int eid, string enm, string eloc, string dept) 
    {
        this.eid = eid;
        this.enm = enm;
        this.eloc = eloc;
        this.dept = dept;
    }

    

    // implementation of the method from the interface 
    // no need to write the override keyword 
    //step 2 
    public string GetHealthInsuranceAmt()
    {
        return "health insurance amt is :1500";
    }

    
}

