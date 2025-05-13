using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_goto_continue_nestedfor_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break 
            for (int i = 0;i <= 10; i++)
            {
                if (i == 5)
                    break;

                System.Console.WriteLine(i);
            }

            // continue 
            for (int i = 0; i <= 10; i++)
            {
                if (i == 6  )
                    continue;

                System.Console.WriteLine(i);
            }

            // nexted for 
            for (int i = 1; i <= 5; i++){

                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                    Console.Write("");
                }
                Console.WriteLine();
            }

            // goto statement
            int k = 1;
            Console.WriteLine("india");
            Console.WriteLine("pakistan");
            Console.WriteLine("nepal");
        mylabel:
            Console.WriteLine("china");
            Console.WriteLine("usa");
            Console.WriteLine("iran");
            k++;
            if (k <= 5)
            {
                goto mylabel;
            }
            
            Console.WriteLine("turkey");
            Console.WriteLine("saudi");
            Console.WriteLine("africa");

            System.Console.ReadKey();
        }
    }
}
