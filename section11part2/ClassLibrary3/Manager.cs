
// child class should implement the properties and methods from both child interface and parent interface
//  IEmployeeChildInterface IPersonParentInterface
public class Manager : IEmployeeChildInterface

{
    // feilds
    private string dept;
    public string Dept { set { dept = value; } get { return dept; } }

    // private fields for interface properties of  IEmployeeChildInterface IPersonParentInterface
    private int eid;
    private string enm;
    private string eloc;
    private System.DateTime dob;

    // implement the properties from both IEmployeeChildInterface IPersonParentInterface
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

    public System.DateTime DateOfBirth { set { dob = value; } get { return dob; } }

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


    // implementation of the method from both interfaces  IEmployeeChildInterface IPersonParentInterface
    // no need to write the override keyword 
    //step 2 
    public string GetHealthInsuranceAmt() // IEmployeeChildInterface
    {
        return "health insurance amt is :1500";
    }

    public int GetAge() // IPersonParentInterface
    {
        return (int)(System.DateTime.Now - dob).TotalDays / 365;
    }

}

