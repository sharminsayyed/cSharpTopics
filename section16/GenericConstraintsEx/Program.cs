class Program
{
    static void Main()
    {
        // create an object of generic class 
        // when we pass a class as a generic parameter all is feilds are made accessible in the generic class 
        MarkPrinter<UGstudent> mp1 = new MarkPrinter<UGstudent>();
        // here student is taken as a reference varaible for ugstudent class 
        mp1.student = new UGstudent() { Marks = 80 };
        //Console.WriteLine(mp1.student.Marks);
        mp1.PrintMarks();


        // create an object of generic class 
        MarkPrinter<PGstudent> mp2 = new MarkPrinter<PGstudent>();
        // here student is taken as a reference varaible for pgstudent class 
        mp2.student = new PGstudent() { Marks = 90 };
        //Console.WriteLine(mp2.student.Marks);
        mp2.PrintMarks();

        Console.ReadKey();
    }
}