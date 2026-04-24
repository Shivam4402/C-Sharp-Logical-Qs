using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicLogical
    {
        public void printSquare()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                //Console.WriteLine("Square of" +i+":"+(i*i) );

                //Console.WriteLine("Square of {0}={1}",i,(i*i));

                Console.WriteLine($"Square of {i}={i * i}");
            }

        }

        //#########################################################################################################################################

        public void swappingOfTwoNumbers()
        {
            int a = 10;
            int b = 20;

            int c;

            //c = a;
            //a = b;
            //b = c;

            //WITHOUT USING 3 Variable

            //a = a + b;
            //b = a - b;
            //a = a - b;

            //a = a ^ b;
            //b = a ^ b;
            //a = a ^ b;

            a = a + b - (b = a);

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }

        //#########################################################################################################################################


        public void checkEvenOdd()
        {
            int num = 4;

            if ((num % 2) == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }

        //#########################################################################################################################################

        public void checkEvenOddBitOperator()
        {
            int num = 4;

            if ((num & 1) == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }

        //#########################################################################################################################################

        public void printSamelineOddEven()
        {

            for (int i = 1; i <= 19; i = i + 2)
            {
                Console.Write(i + "/" + (i + 1));

                if (i < 19)
                {
                    Console.Write("+");
                }
            }


            //for (int i = 1; i <= 19; i = i + 2)
            //{
            //    Console.Write(i + "/" + (i + 1) + "+");
            //}

        }
        //OPUTPUT:: 1/2+3/4+5/6+7/8+9/10+11/12+13/14+15/16+17/18+19/20

        //#########################################################################################################################################

        public void printFizzBuzz()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz-Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        //#########################################################################################################################################


        public void print9Series()
        {
            int n = 6;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = num * 10 + 9;

                Console.Write(num);

                if (i != n)
                    Console.Write(" + ");
            }

        }

        //[OUTPUT]:

        //9 + 99 + 999 + 9999 + 99999 + 999999

        //#########################################################################################################################################





    }
}
