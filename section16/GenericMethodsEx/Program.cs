class Program
{
    static void Main()
    {
        Sample s = new Sample();
        Student stu = new Student() { Marks =90};
        Employee emp = new Employee() { Salary =23000};

        // call the generic method where we pass parameter only of class type 
        // here we can pass stu object and emp object of particular class 
        s.PrintData<Student>(stu);

        s.PrintData<Employee>(emp);

        Console.ReadKey();
    }
}