
// read only structure
public readonly struct Marvel
{
    // feild 
    private readonly string  _characternm;

    // constructor can intailize the feilds of readonly structures 

    public Marvel(string nm)
    {
        this._characternm = nm;
    }


    // properties with only get accessor 
    public string Characternm { get { return _characternm; } }

    //methods can only read value of feilds they cannot modify them 
    public void PrintCharacterName()
    {
        Console.WriteLine(this.Characternm);
        //this.Characternm = "addf"; // if u do this it will give a compile time error 
    }
}