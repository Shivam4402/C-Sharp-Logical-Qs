using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PatternsByYuvrajSir
    {

        public void pattern1()
        {
            int num = 5;

            int temp = 1;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(temp + " ");
                    temp++;
                }
                Console.WriteLine();
            }

        }

        //OUTPUT:

        //1 2 3 4 5
        //6 7 8 9 10
        //11 12 13 14 15
        //16 17 18 19 20
        //21 22 23 24 25

        //#########################################################################################################################################


        public void pattern2()
        {
            int num = 5;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }

        //OUTPUT:

        //1
        //1 2
        //1 2 3
        //1 2 3 4
        //1 2 3 4 5

        //#########################################################################################################################################

        public void pattern3()
        {
            int num = 5;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }

        //OUTPUT:

        //1
        //2 2
        //3 3 3
        //4 4 4 4
        //5 5 5 5 5

        //#########################################################################################################################################


        public void pattern4()
        {
            int num = 5;

            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }

        //OUTPUT:

        //1 2 3 4 5
        //1 2 3 4
        //1 2 3
        //1 2
        //1

        //#########################################################################################################################################


        public void pattern5()
        {
            int num = 5;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        //OUTPUT:

        //5 4 3 2 1
        //5 4 3 2
        //5 4 3
        //5 4
        //5

        //#########################################################################################################################################


        public void pattern6()
        {
            int num = 5;

            for (int i = num; i >= 1; i--)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        //OUTPUT:

        //5
        //5 4
        //5 4 3
        //5 4 3 2
        //5 4 3 2 1

        //#########################################################################################################################################



        public void pattern7()
        {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {

                for (int j = num; j >= i; j--)
                {
                    Console.Write("  ");
                }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        //OUTPUT:

        //        1
        //      2 1
        //    3 2 1
        //  4 3 2 1
        //5 4 3 2 1

        //#########################################################################################################################################


        public void pattern8()
        {
            int num = 5;

            for (int i = 1; i <= num; i++)
            {

                for (int j = num; j >= i; j--)
                {
                    Console.Write("  ");
                }


                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        //OUTPUT:

        //        1
        //      2 1 2
        //    3 2 1 2 3
        //  4 3 2 1 2 3 4
        //5 4 3 2 1 2 3 4 5

        //#########################################################################################################################################


        public void pattern9()
        {
            int num = 5;

            for (int i = num; i >= 1; i--)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }

        }
        //OUTPUT:

        //5 4 3 2 1
        //4 3 2 1
        //3 2 1
        //2 1
        //1


        //#########################################################################################################################################





















    }
}
