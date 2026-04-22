using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {


        void binaryToDecimal()
        {
            Console.WriteLine("Enter Binary Code:");
            int binNum = Convert.ToInt32(Console.ReadLine());

            int ans = 0;
            int pow = 1;
            int count = 0;

            while (binNum > 0)
            {
                int rem = binNum % 10;
                if (rem == 1)
                {
                    count++;
                }
                ans = ans + (rem * pow);
                binNum = binNum / 10;
                pow = pow * 2;
            }

            Console.WriteLine("Your Decimal Number:" + ans);
            Console.WriteLine("Count 0f 1:" + count);

        }



        

        void decimalToBinary()
        {
            Console.WriteLine("Enter Decimal Value:");
            int deciNum = Convert.ToInt32(Console.ReadLine());


            int ans = 0;
            int pow = 1;
            int count = 0;
            while (deciNum > 0)
            {
                int rem = deciNum % 2;
                if (rem == 1)
                {
                    count++;
                }
                ans = ans + (rem * pow);
                deciNum = deciNum / 2;
                pow = pow * 10;
            }

            Console.WriteLine("Your Binary Code:" + ans);
            Console.WriteLine("Count 0f 1:" + count);



        }






        void countOfDigit()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int rem = num % 10;
                sum = sum +rem;
                num = num / 10;
            }

            Console.WriteLine(sum);
        }



        void reverseString()
        {
            string str = "SHIVAM";

            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
      
        }



        void ascendingArray()
        {
            int[] a = { 5, 4, 3, 8, 2, 7 };

            for (int i = 0; i < a.Length; i++)
            {
                for(int j = i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending Array:");
            for (int i = 0;i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }





        void pattern1()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n ; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }


        void pattern2()
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


        void pattern3()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }

                Console.WriteLine();
            }
        }


        void pattern4()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                char ch = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch+" ");
                    ch++;
                }

                Console.WriteLine();
            }
        }


        void pattern5()
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



        void pattern6()
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



        void pattern7()
        {
            int n = 5;

            for(int i = 1; i<=n; i++)
            {
                for(int j=1; j<= n-i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i ; j++)
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




        void pattern8()
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



        void pattern9()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
               

                for (int j = 1; j <= n; j++)
                {
                    if (i ==1 || j==1 || i==n || j==n )
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


        void pattern10()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {


                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || i+j==6)
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




        void patternX()
        {
            int n = 7;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if(i==j || i + j == n + 1)
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



        void patternV()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n*2; j++)
                {
                    if (i == j || i + j == n*2)
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













        void powerOfNumber()
        {
            int a = 3, b = 3;
            int c = 1;

            while (b != 0)
            {
                c = c * a;
                b--;
            }

            Console.WriteLine(c);
        }


        void sumOfDigits()
        {
            int num = 123;
            int sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits:"+sum);
        }









        static void Main(string[] args)
        {
            Program program = new Program();



            //program.powerOfNumber();

            //program.sumOfDigits();




            //program.binaryToDecimal();
            //Console.WriteLine();


            //program.decimalToBinary();
            //Console.WriteLine();


            //program.fibSeries(0, 1);
            //Console.WriteLine();


            //program.printPrime();
            //Console.WriteLine();


            //program.factorialNumber();
            //Console.WriteLine();


            //program.countOfDigit();
            //Console.WriteLine();


            //program.reverseString();
            //Console.WriteLine();


            //program.ascendingArray();
            //Console.WriteLine();


            //program.OneToTen(1);
            //Console.WriteLine();

            //program.TenToOne(10);
            //Console.WriteLine();


            //program.Table5WithoutLoop(1);
            //Console.WriteLine();


            //program.FibSeriedWithoutLoop(0, 1);
            //Console.WriteLine();

            //program.FactorialWithoutLoop(5);
            //Console.WriteLine();





















































            //[YOUTUBE CHANNEL]: Sheryians Coding School
            //[YOUTUBE LINK]: https://www.youtube.com/watch?v=NaRPbIXRwhE&list=PLbtI3_MArDOmSKABu09sEs0SxCibd1wgr&index=7

            //program.pattern1();
            //Console.WriteLine();

            //[OUTPUT]:
            //*****
            //*****
            //*****
            //*****
            //*****

            //program.pattern2();
            //Console.WriteLine();

            //[OUTPUT]:
            //*
            //**
            //***
            //****
            //*****

            //program.pattern3();
            //Console.WriteLine();

            //[OUTPUT]:
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5


            //program.pattern4();
            //Console.WriteLine();

            //[OUTPUT]:
            //A
            //A B
            //A B C
            //A B C D
            //A B C D E

            //program.pattern5();
            //Console.WriteLine();

            //[OUTPUT]:
            //*****
            //****
            //***
            //**
            //*

            //program.pattern6();
            //Console.WriteLine();

            //[OUTPUT]:
            //        *
            //      **
            //    ***
            //  ****
            //*****


            //program.pattern7();
            //Console.WriteLine();

            //[OUTPUT]:
            //    *
            //   ***
            //  *****
            // *******
            //*********


            //program.pattern8();
            //Console.WriteLine();

            //[OUTPUT]:
            //        *
            //      @@
            //    ***
            //  @@@@
            //*****


            //program.pattern9();
            //Console.WriteLine();

            //[OUTPUT]:
            //*****
            //*   *
            //*   *
            //*   *
            //*****



            //program.pattern10();
            //Console.WriteLine();

            //[OUTPUT]:
            //  *****
            //      *
            //    *
            //  *
            //*****



            //program.patternX();
            //Console.WriteLine();

            //program.patternV();
            //Console.WriteLine();





            //#########################################################################################################################################

            BasicLogical b = new BasicLogical();

            //Console.WriteLine("printSquare");
            //b.printSquare();
            //Console.WriteLine();

            //Console.WriteLine("swappingOfTwoNumbers");
            //b.swappingOfTwoNumbers();
            //Console.WriteLine();

            //Console.WriteLine("checkEvenOdd");
            //b.checkEvenOdd();
            //Console.WriteLine();

            //Console.WriteLine("checkEvenOddBitOperator");
            //b.checkEvenOddBitOperator();
            //Console.WriteLine();

            //Console.WriteLine("printSamelineOddEven");
            //b.printSamelineOddEven();
            //Console.WriteLine();

            //Console.WriteLine("printFizzBuzz");
            //b.printFizzBuzz();
            //Console.WriteLine();



            //#########################################################################################################################################



            ForLoop f = new ForLoop();

            //Console.WriteLine("printFibSeries");
            //f.printFibSeries();
            //Console.WriteLine();

            //Console.WriteLine("checkPrimeNumber");
            //f.checkPrimeNumber();
            //Console.WriteLine();

            //Console.WriteLine("printPrimeNumSeries");
            //f.printPrimeNumSeries();
            //Console.WriteLine();

            //Console.WriteLine("factorialOfNumber");
            //f.factorialOfNumber();
            //Console.WriteLine();



            //#########################################################################################################################################


            BasicRecursion br = new BasicRecursion();


            //Console.WriteLine("printOneToTenNumbersWithoutLoop");
            //br.printOneToTenNumbersWithoutLoop(1);
            //Console.WriteLine();

            //Console.WriteLine("printTenToOneNumbersWithoutLoop");
            //br.printTenToOneNumbersWithoutLoop(10);
            //Console.WriteLine();

            //Console.WriteLine("fibSeriesWithoutLoop");
            //br.fibSeriesWithoutLoop(0, 1);
            //Console.WriteLine();

            //Console.WriteLine("factorialWithoutLoop");
            //br.factorialWithoutLoop(5);
            //Console.WriteLine();


            //#########################################################################################################################################


            PatternsByYuvrajSir pt = new PatternsByYuvrajSir();

            //Console.WriteLine("pattern1");
            //pt.pattern1();
            //Console.WriteLine();

            //Console.WriteLine("pattern2");
            //pt.pattern2();
            //Console.WriteLine();

            //Console.WriteLine("pattern3");
            //pt.pattern3();
            //Console.WriteLine();

            //Console.WriteLine("pattern4");
            //pt.pattern4();
            //Console.WriteLine();

            //Console.WriteLine("pattern5");
            //pt.pattern5();
            //Console.WriteLine();

            //Console.WriteLine("pattern6");
            //pt.pattern6();
            //Console.WriteLine();

            //Console.WriteLine("pattern7");
            //pt.pattern7();
            //Console.WriteLine();

            //Console.WriteLine("pattern8");
            //pt.pattern8();
            //Console.WriteLine();

            //Console.WriteLine("pattern9");
            //pt.pattern9();
            //Console.WriteLine();


            //#########################################################################################################################################

            WhileLoop w = new WhileLoop();

            w.decimalToBinary();







        }
    }
}
