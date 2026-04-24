using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ForLoop
    {


        public void printMessageWithoutSemicolon()
        {
            int i = 1;
            for (; i <= 1; Console.WriteLine("Welcome To C#"))
            {
                i++;
            }
        }

        //#########################################################################################################################################



        public void multiplyWithoutStarOperator()
        {
            //without using * operator.

            int a = 3;
            int b = 3;

            int c = 0;

            for (int i = 1; i <= b; i++)
            {
                c = c + a;
            }

            Console.WriteLine("Multiplication without * Operator: " +c);

        }

        //#########################################################################################################################################




        public void printFibSeries()
        {
            int a = 0, b = 1;

            Console.WriteLine("Fib Series:");



            //WITH THIRD VARIABLE

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(a + " ");
            //    b = a + b;
            //    a = b - a;
            //}


            //WITHOUT THIRD VARIABLE

            for (; a <= 34;)
            {

                Console.WriteLine(a + " ");
                b = a + b;
                a = b - a;
            }



            //USING RECURSION

            //void fibSeries(int a, int b)
            //{
            //    if (a <= 34)
            //    {
            //        Console.WriteLine(a);
            //        b = a + b;
            //        a = b - a;
            //        fibSeries(a, b);
            //    }
            //}

            //p.fibSeries(0, 1);

        }

        //#########################################################################################################################################


        public void checkPrimeNumber()
        {
            int num = 7;
            int count = 0;

            for (int i = 2; i <= num / 2; i++)
            {

                if (num % i == 0)
                {
                    count++;
                    break;
                }

            }

            if (count == 0)
                Console.WriteLine($"{num} is PRIME");
            else
                Console.WriteLine($"{num} is NOT PRIME");

        }

        //#########################################################################################################################################

        public void printPrimeNumSeries()
        {

            Console.WriteLine("Enter Number to print prime series from:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int j = 2; j <= num; j++)
            {
                int count = 0;

                for (int i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(j);
                }

            }

        }


        //#########################################################################################################################################

        public void factorialOfNumber()
        {
            int num = 5;
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine($"Factorial of a {num} is: {fact}");
        }

        //#########################################################################################################################################



        public void CheckSemiPrimeOrNot()
        {
            int IsPrime(int n)
            {
                if (n < 2)
                {
                    return 0;
                }

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }


            Console.WriteLine("Enter Number To Check it is SemiPrime Or Not:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    int j = num / i;

                    if (IsPrime(i) == 1 && IsPrime(j) == 1)
                    {
                        count++;
                        break;
                    }
                }
            }


            if (count == 1)
            {
                Console.WriteLine(num + " is a Semiprime number.");
            }
            else
            {
                Console.WriteLine(num + " is NOT a Semiprime number.");
            }

        }

        //#########################################################################################################################################




    }
}
