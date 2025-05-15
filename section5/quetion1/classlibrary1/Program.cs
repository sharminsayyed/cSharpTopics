/*
 Step 2: Create a class called Employee in the class library with fields EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. Additionally, add the following fields:

    - A static field called OrganizationName. It should be initialized as "Harsha Inc." in Main method.

    - A constant field called TypeOfEmployee and initialize it as "Contract Based" along with declaration.

    - A readonly field called DepartmentName and initialize it as "Finance Department" in constructor.
*/

public class Employee
{
    public int id;
    public string name;
    public double salPerHour;
    public double noOfWH;
    public double netSal;
    public static string orgName;
    public const string typeOfEmp = "Constract-Based";
    public readonly string deptName;

    public Employee()
    {
        deptName = "Finance Department";
    }

}

class sample
{
    static void Main()
    {

    }
}