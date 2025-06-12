public interface IPerson
{
    // auto implemented properties
    System.DateTime DateOfBirth { set; get; }

    // abstract method 
    int GetAge();
}