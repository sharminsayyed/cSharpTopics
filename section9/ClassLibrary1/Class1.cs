
using System.Reflection.Metadata.Ecma335;

public class Employee
{
    private int _eid; // instance field - private _ to indicate it is an private field
    private string _enm;
    private string _ejob;
    private double _esal;
    private double _etax;

    private static string _companynm; // static field

    // properties 
    // create a property(set get) for the fields which are private 
    // validate the value passed to property and then assign it to the field - (set)
    // return the value of feild with the help of property - (get)

    //instance property
    public int EmpId
    {
        set { 
                if(value >= 100)
                {
                    _eid = value;
                }
        }
        get { return _eid; }
    }

    public string EmpNm
    {
        set { _enm = value; }
        get { return _enm; }
    }

    public string EmpJob
    {
        set { _ejob = value; }
        get { return _ejob; }
    }

    //static property
    public static string CompanyNm
    {
        set { 
            if (value.Length <= 20)
            {
                _companynm = value;
            }
           
        }
        get { return _companynm; }
    }

    // read-only property 
    public double Empsal
    {
        get { return _esal; }
    }

    // write-only property 
    public double EmpTax
    {
        set { 
            if(value > 0 && value <=10000) { _etax = value; }
        }
    }

    // automated property - used when we dont have to perform validation and calculation logic 
    // compiler automatically create a private field - _propertyname
    public string NativePl { set; get; } = "New York"; // _NativePl - private field will be created 
    // here new york is a default value given to the property which can be overwritten 
    
    public Employee() { this._esal = 1000; }
    // in constructor we cannot use the properties as we directly intialize value to the feilds 

    // indexers  
    // accessmodifier modifier typ
    public Employee(int eid, string enm, string ejob)
    {
        this._eid = eid;
        this._enm = enm;
        this._ejob = ejob;
        this._esal = 1000;
    }
    
}