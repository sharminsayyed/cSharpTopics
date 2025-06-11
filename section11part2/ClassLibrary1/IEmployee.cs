
// interface contains abstract methods only method declaration  
// by default abstract and public 
// child class should implement all the methods (definition) present in the interface 
// child class can implement multiple interface (multiple inheritance )

public interface IEmployee
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