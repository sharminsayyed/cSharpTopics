using System;
/* qs1
Write a program to findout "category of height" based on the given height of a person (in inches), using "if".
Height categories:
Height is less than 150 cm = "Dwarf"
Height is between 150 cm and 165 cm = "Average height"
Height is between 165 cm and 195 cm = "Tall"
Height is above 195 cm = "Abnormal height"

Note: 1 inch = 2.54 centimeter

Eg:
Input: 75
Output: Tall


*/
/* qs2 
Write a C//program to find out largest number among three numbers, using "if".
Eg:
num1 = 60
num2 = 45
num3 = 123
Output: 123
*/
namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // qs 1 
            Console.WriteLine("enter the height in inches :");
            int inches = int.Parse(Console.ReadLine());
            double height = inches * 2.45;
            if (height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (height >= 150 && height <= 165)
            {
                Console.WriteLine("Average height");
            }
            else if (height >= 165 && height <= 195)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }


            // qs2 
            int n1 = 60, n2 = 45, n3 = 123;
            int output = 0;
            if(n1>= n2)
            {
                if (n1>=n3 )
                {
                    output = n1;
                }
                else
                {
                    output = n3;
                }
            }
            else if(n2 >= n3)
            {
                output = n2;
            }
            else
            {
                output = n3;
            }

            Console.WriteLine(output);
                Console.ReadKey();
        }
    }
}
