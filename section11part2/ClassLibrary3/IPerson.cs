
// parent interface 
public interface IPersonParentInterface
{
    // auto implemented properties
    System.DateTime DateOfBirth { set; get; }

    // abstract method 
    int GetAge();
}