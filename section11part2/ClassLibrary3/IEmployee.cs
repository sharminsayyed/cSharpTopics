
// child interface which will implement the parent interface
public interface IEmployeeChildInterface :IPersonParentInterface
{
    // no fields , constructors ,   


    // auto implemented properties 
    public int Empid { set; get; }
    public string Empname { set; get; }
    public string Emploc { set; get; }

    // method only provide the method decclaration /signature 
    // the child classes should provide implementation to these methods 
    // step 1 
    // methods by default abstract and public 
    // returntype methodname(para);

    string GetHealthInsuranceAmt();


}