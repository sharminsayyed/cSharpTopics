// generic class 
//A generic class in C# allows you to create a class that works with any data type (like int, string, float, or even custom types), while maintaining type safety and code reusability.

//The generic type parameter (T) acts as "temporary data type", which represents the actual data type, provided by the user, while creating object.
//You can have multiple "generic type parameters" in the same class (for use for different fields.Generics are introduced in C# 2.0.
public class User <T1 ,T2>
{
    // generic feild
    public T1 registrationStatus;

    // another generic feild
    // both feilds can have different datatypes assigned to them 
    public T2 age;
}