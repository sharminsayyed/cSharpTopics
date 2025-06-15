public class Person
{
    public string Pname { set; get; }
    public string Pemail { set; get; }

    public AgeGroupEnumeration AgeGroup { set; get; }
}

// enumeration is a collection of constants 
// we can use enumeration as datatype for any property , feild or method ,parameter type 
// enumeration is assigned a values (inetger)  such as child =0 , teenager =1, adult =2, senior =3
//we can also assign value to the constant in the enumeration

// by default each constant will be assigned to a number starts from zero however u can change the number
// the default data type of enum member is int , however u can change its data type also

public enum AgeGroupEnumeration :short
{
    Child,
    Teenager,
    Adult,
    Senior,
    toodler =100, // value is assigned 
    baby
}

