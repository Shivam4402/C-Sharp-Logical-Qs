using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PatternsBySheryians
    {
        public void pattern1()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //*****
        //*****
        //*****
        //*****
        //*****

        //#########################################################################################################################################



        public void pattern2()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //*
        //**
        //***
        //****
        //*****

        //#########################################################################################################################################


        public void pattern3()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //1
        //1 2
        //1 2 3
        //1 2 3 4
        //1 2 3 4 5

        //#########################################################################################################################################


        public void pattern4()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                char ch = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch + " ");
                    ch++;
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //A
        //A B
        //A B C
        //A B C D
        //A B C D E

        //#########################################################################################################################################


        public void pattern5()
        {
            int n = 5;


            //[LOGIC 1]

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i+1; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}



            //[LOGIC 2]

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j >= i; j--)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}



            //[LOGIC 3]

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //*****
        //****
        //***
        //**
        //*

        //#########################################################################################################################################



        public void pattern6()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //        *
        //      **
        //    ***
        //  ****
        //*****

        //#########################################################################################################################################


        public void pattern7()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //    *
        //   ***
        //  *****
        // *******
        //*********

        //#########################################################################################################################################



        public void pattern8()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("@ ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }


                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //        *
        //      @@
        //    ***
        //  @@@@
        //*****

        //#########################################################################################################################################



        public void pattern9()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {


                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1 || i == n || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }


                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //*****
        //*   *
        //*   *
        //*   *
        //*****

        //#########################################################################################################################################


        public void pattern10()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {


                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || i + j == 6)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }


                Console.WriteLine();
            }
        }

        //[OUTPUT]:
        //  *****
        //      *
        //    *
        //  *
        //*****

        //#########################################################################################################################################


        public void patternX()
        {
            int n = 7;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == j || i + j == n + 1)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

        }

        //#########################################################################################################################################



        public void patternV()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n * 2; j++)
                {
                    if (i == j || i + j == n * 2)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

        }

        //#########################################################################################################################################






    }
}
