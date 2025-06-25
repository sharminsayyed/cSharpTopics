namespace InnerClass
{
    class Program
    {
        static void Main()
        {
            // create an object of inner class 
            // mention the outeer class also 
            ClassLibrary4.MarksCalculation.CalculationHelper c1 = new ClassLibrary4.MarksCalculation.CalculationHelper();

            Console.WriteLine(c1.Multiply(10,5));

            // create a object of puter class 
            ClassLibrary4.Student s = new ClassLibrary4.Student() { marks = 35, maxMarks = 100 };
            ClassLibrary4.MarksCalculation mc = new ClassLibrary4.MarksCalculation();
            mc.CalcualtePer(s);
            Console.WriteLine(s.percentage);
            Console.ReadKey();


        }
    }
}