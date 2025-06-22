// generic methods 
//A generic method is a method that allows you to work with any data type while maintaining type safety.
//Unlike generic classes, you define the type parameter only for the method, not the whole class.
// when ever u are not sure about the datatype of the method u use generic method 
public class Employee
{
    public int Salary;
}

public class Student
{
    public int Marks;
}

// class with generic methods
public class Sample
{
    // generic method 
     public void PrintData<T> (T obj) where T:class
     {
        if(obj.GetType() == typeof(Student))
        {
            // assigning object to student class 
            Student t = obj as Student;
            Console.WriteLine(t.Marks);
        }
        else if(obj.GetType() == typeof(Employee))
        {
            Employee temp = obj as Employee;
            Console.WriteLine(temp.Salary);
        }
     }
}