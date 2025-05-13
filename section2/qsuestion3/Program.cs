using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# program to print the following output:

1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3
10 9 8 7 6 5 4 3 2 1
1 2 3 4 5 6 7 9 10
*/

namespace qsuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first 3 lines
            for(int i= 1; i<= 3;i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    if(j== 5 && j == 6)
                    {
                        continue;
                    }
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            // line 4,5,6,7,
            for(int i= 0; i < 4; i++)
            {
                for (int j = 10; j >= 1; j--)
                {
                    if (i == 2)
                    {
                        if(j == 2 || j == 1)
                        {
                            continue;
                        }
                    }
                    Console.Write(j);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

            // line 8
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                Console.Write(" ");

            }
            Console.ReadKey();
        }
    }
}
