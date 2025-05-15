/*
 Step 1: Create a class library and console application. Add reference of class library into console application.



Step 2: Create a class called Employee in the class library with fields EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. Additionally, add the following fields:

    - A static field called OrganizationName. It should be initialized as "Harsha Inc." in Main method.

    - A constant field called TypeOfEmployee and initialize it as "Contract Based" along with declaration.

    - A readonly field called DepartmentName and initialize it as "Finance Department" in constructor.



Step 3: Create an object of Employee class in the console application. Read each employee details (EmpID, EmpName, SalaryPerHour, NoOfWorkingHours) from the user (from the keyboard) using loop.

Calculate net salary (SalaryPerHour * NoOfWorkingHours).

And display the all details of the same object (including EmpID, EmpName, SalaryPerHour, NoOfWorkingHours, NetSalary, OrganizationName, TypeOfEmployee, DepartmentName) and then ask the user 'Do you want to continue to next employee'.

If the user choose 'Yes', proceed to the next employee; otherwise stop the loop.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("employee details for the organization");
        Console.WriteLine("-----------------------------------------------------");
        Employee.orgName = "Harsha Inc.";
        // for loop for employee
        for(int i= 0;i < 5; i++)
        {
            string employeeno = null;
            switch (i)
            {
                case 0: employeeno = "first employee";break;
                case 1: employeeno = "second employee"; break;
                case 2: employeeno = "third employee"; break;
                case 3: employeeno = "four employee"; break;
                case 4: employeeno = "fifth employee"; break;

            }

            Employee e = new Employee(); // create an object 
            // get the details from the user (from keyboard)
            Console.WriteLine("enter the details for the " + employeeno + " :");
            Console.Write("id :");
            e.id = int.Parse(Console.ReadLine());
            Console.Write("name :");
            e.name = Console.ReadLine();
            Console.Write("salary per hour :");
            e.salPerHour = double.Parse(Console.ReadLine());
            Console.Write("no of working hours :");
            e.noOfWH = double.Parse(Console.ReadLine());


            // cal net salary 
            e.netSal = e.salPerHour * e.noOfWH;

            // display the details
            Console.WriteLine();
            Console.Write(" employee number :"+employeeno
                +"\n id :"+e.id
                +"\n name:"+e.name  
                +"\n salary per hour: "+e.salPerHour
                +"\n no of working hours  :"+e.noOfWH
                +"\n net salary  :"+e.netSal
                +"\n organization name :"+Employee.orgName
                +"\n type of employee :"+Employee.typeOfEmp
                +"\n department name  :"+e.deptName);

            Console.WriteLine("\ndo u want to continue to add another employee (yes or no ) :");
            string choice = Console.ReadLine();
            if (choice == "no") { break; }

            Console.WriteLine("-----------------------------------------------------");
        }
        Console.WriteLine("details saved ");
        Console.ReadKey();
    }
}

