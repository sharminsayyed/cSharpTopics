class Program
{
    static void Main()
    {
        // create an object 
        Person p = new Person();
        p.Pemail = "sharmin@gmail.com";
        p.Pname = "sharmin";
        // any one specified value can be assigned from the enumeration 
        p.AgeGroup = AgeGroupEnumeration.Adult;

        Console.WriteLine(p.AgeGroup = AgeGroupEnumeration.toodler);

        Console.ReadKey();
    }
}