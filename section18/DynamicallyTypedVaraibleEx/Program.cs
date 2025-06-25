using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DynamicallyTypedVaraible
{
    class Student
    {
        public string StudentClass { set; get; }
    }
    class Program
    {
        static void Main()
        {
            // when u are not sure what type of value u want to store than use dynamic keyword 
            // create a dynamically typed vaaible - use dynamic keyword
            // here declare without any specific datatype 
            dynamic x;
            //u can assign any type of data 
            // datatype is not fixed and value is also not fixed 
            x = 100;
            x = "hello";
            x = new Student() { StudentClass = "tybca"};
            // before calling any property ,feild , method we should check if it is present in the class
            //Console.WriteLine(x.Studentname); // will give an error 
            Console.WriteLine(x.StudentClass as String );

            Console.ReadKey();

            //The "dynamic" type variables are converted as "object" type in most cases. Eg: dynamic dynamicVariable = 100; -> object dynamicaVariable = 100;

            //The Dynamically Typed Variable can change its data type, any no. of times, at run time.

            //Methods and other members of 'dynamically typed variables' will not be checked by the compiler at compilation time; will be checked by CLR at run time.

            //If the method or other member not available, it would not cause compile-time error; it raises run - time error, when the execution flow encountered that particular statement. Eg: dynamicVariable.NonExistingMethod(); //run-time error (exception)

            //The Dynamically Typed Variables need not be initialized, while declaration.
            
            //The Dynamically Typed Variable doesn't have "Intellisense" in Visual Studio.

            //The "dynamic" keyword is allowed for local variables, method parameters, fields, properties, return types etc.


        }
            }
}