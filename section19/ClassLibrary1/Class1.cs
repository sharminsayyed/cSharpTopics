namespace ClassLibrary1
{
    public class Sample
    {
        // constructor 
        public Sample()
        {
            // file and db connection can be done here 
            Console.WriteLine("file is opened");
        }

        //destructor 
        // it executes automatically before deleting the object from the heap memory
        // majorly used for unmanaged resources (file and data connection)
        ~Sample()
        {
            // closing logic can be writteh here 
            Console.WriteLine("file is closed");
        }
        // generally objects are deleted at the end of the application 
    }
}
