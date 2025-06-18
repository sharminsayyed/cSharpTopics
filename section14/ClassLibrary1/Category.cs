public struct Category
{
    // structure is very similar to class 
    // structure is a value type where as class is reference type 
    // can contain feilds methods parameterized constructor properties events 

    // if u want to store simple values 1 or 2 fields use structures 
    // structures are bit faster than classes beacuse they are store in stack 
    // it does not support inheritance 


    // private fields 
    private int _cid;
    private string _cnm;

    // c# provides a parameter less constructor to intialize all the fields 
    // parameterized constructor - intailize all the fields , new keyword is used to call constructor

    public Category(int id , string nm)
    {
        _cid = id;
        _cnm = nm;
    }

    //public fields 
    public int Cid
    {
        set
        {
            if(value >=1 && value<= 100) { _cid = value; }
        }
        get { return _cid; }
    }

    public string Cnm
    {
        set
        {
            if (value.Length <= 40) { _cnm = value; }
        }
        get { return _cnm; }
    }

    // methods 
    public int GetCategoryNameLength()
    {
        return _cnm.Length;
    }
}