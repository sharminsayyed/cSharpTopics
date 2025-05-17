using System;

class Sample
{
    public double CalFactorial(int number)
    {
        if (number == 0) { return 1; } //called as base case - due to which recursive function will stop 
        else
        {
            return number * CalFactorial(number - 1);
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a number :");
        int n = int.Parse(Console.ReadLine());
        Sample s = new Sample();
        double res = s.CalFactorial(n);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}