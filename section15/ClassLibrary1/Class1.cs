public class Person
{
    // by default person class is child class of System.Object class (ultimate parent class)
    // properties 
    public string Pname { set; get; }
    public string Pemail { set; get; }

    // override the methods of System.Object class 

    // equals method 
    public override bool Equals(object obj)
    {
        Person p = (Person)obj;
        if(this.Pname == p.Pname  && this.Pemail == p.Pemail)  
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //to string method 
    public override string ToString()
    {
        return "person name :" + Pname + " \n person email :" + Pemail;
    }
}