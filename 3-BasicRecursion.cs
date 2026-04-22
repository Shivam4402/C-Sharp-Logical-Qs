using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicRecursion
    {

        //#########################################################################################################################################

        public void printOneToTenNumbersWithoutLoop(int i)
        {

            if (i <= 10)
            {
                Console.WriteLine(i);
                i++;
                printOneToTenNumbersWithoutLoop(i);
            }
            else
            {
                Console.WriteLine("Finshed..");
            }

        }

        //p.printOneToTenNumbersWithoutLoop(1);

        //#########################################################################################################################################

        public void printTenToOneNumbersWithoutLoop(int i)
        {

            if (i >= 1)
            {
                Console.WriteLine(i);
                i--;
                printTenToOneNumbersWithoutLoop(i);
            }
            else
            {
                Console.WriteLine("Finshed..");
            }

        }

        //p.printTenToOneNumbersWithoutLoop(10);


        //#########################################################################################################################################

        public void fibSeriesWithoutLoop(int a, int b)
        {
            Console.WriteLine(a);
            b = a + b;
            a = b - a;

            if (a < 100)
            {
                fibSeriesWithoutLoop(a, b);
            }
            else
            {
                Console.WriteLine("FINNISHED");
            }
        }

        //p.fibSeriesWithoutLoop(0,1);


        //#########################################################################################################################################



        int fact = 1;
        public void factorialWithoutLoop(int num)
        {

            if (num == 0)
            {
                Console.WriteLine(fact);
                return;
            }

            fact = fact * num;

            factorialWithoutLoop(num - 1);

        }

        //p.factorialWithoutLoop(5);


        //#########################################################################################################################################


      


    }
}
