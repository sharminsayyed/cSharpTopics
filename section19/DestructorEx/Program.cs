
using ClassLibrary1;
namespace DestructorEx
{
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();

            s = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        // destructor is called automatically
    }
}