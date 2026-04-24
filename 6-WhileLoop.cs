using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WhileLoop
    {


        public void countOfDigit()
        {
            int n, cnt = 0;
            Console.WriteLine("Enter Any Number:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                cnt++;
                n = n / 10;
            }
            Console.WriteLine("Total Digits Are:" + cnt);
        }

        //#########################################################################################################################################



        public void sumOfDigits()
        {
            int num = 123;
            int sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits:" + sum);
        }

        //#########################################################################################################################################





        public void reverseOfNumber()
        {
            int n, rem, rev = 0;

            Console.WriteLine("Enter Any Number");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse of a Number is: " + rev);

        }

        //#########################################################################################################################################




        public void checkPalindromeNumber()
        {
            int n, rem, rev = 0;

            Console.WriteLine("Enter Any Number:");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;

            while (temp != 0)
            {
                rem = temp % 10;
                rev = rev * 10 + rem;
                temp = temp  / 10;
            }

            if (n == rev)
            {
                Console.WriteLine("{0} Number is a Palindrome", n);
            }
            else
            {
                Console.WriteLine("{0} Number is NOT Palindrome", n);
            }


        }

        //#########################################################################################################################################






        public void binaryToDecimal()
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
            Console.WriteLine("Count 0f 1 in Binary Code:" + count);
        }

        //#########################################################################################################################################




        public void decimalToBinary()
        {
            Console.WriteLine("Enter Decimal Value:");
            int deciNum = Convert.ToInt32(Console.ReadLine());

            int ans = 0;
            int pow = 1;
            int count = 0;
            string transpose = "";

            while (deciNum > 0)
            {
                int rem = deciNum % 2;

                if (rem == 1)
                {
                    transpose = '0' + transpose;
                    count++;
                }
                else
                {
                    transpose = '1' + transpose;

                }
                ans = ans + (rem * pow);
                deciNum = deciNum / 2;
                pow = pow * 10;
            }

            Console.WriteLine("Your Binary Code:" + ans);
            Console.WriteLine("Count 0f 1 in Binary Code:" + count);
            Console.WriteLine("Transpose:" + transpose);
        }

        //#########################################################################################################################################





        public static int ToBinary(int deciNum)
        {
            int ans = 0;
            int pow = 1;
        
            while (deciNum > 0)
            {
                int rem = deciNum % 2;
                ans = ans + (rem * pow);
                deciNum = deciNum / 2;
                pow = pow * 10;
            }

            return ans;
        }

        public void printBinaryOfOneToHundred()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Decimal: {i} => Binary: {ToBinary(i)}");
            }
        }


        //#########################################################################################################################################



        //BASIC VERSION

        //public void checkArmstrongNumber()
        //{
        //    int n, rem, sum = 0, pow = 0;

        //    Console.WriteLine("Enter Any Number:");
        //    n = Convert.ToInt32(Console.ReadLine());

        //    int temp = n;

        //    // Count number of digits
        //    while (temp != 0)
        //    {
        //        pow++;
        //        temp = temp / 10;
        //    }

        //    temp = n;

        //    // Calculate Armstrong sum
        //    while (temp != 0)
        //    {
        //        rem = temp % 10;

        //        // METHOD 1: Manual power calculation

        //        //int result = 1;
        //        //int baseVal = rem;
        //        //int exponent = pow;

        //        //while (exponent != 0)
        //        //{
        //        //    result = result * baseVal;
        //        //    exponent--;
        //        //}

        //        //sum = sum + result;

        //        // METHOD 2: Using Math.Pow method
        //        sum = sum + (int)Math.Pow(rem, pow);



        //        temp = temp / 10;
        //    }

        //    Console.WriteLine("SUM: " + sum);

        //    if (sum == n)
        //    {
        //        Console.WriteLine("{0} is an ARMSTRONG", n);
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} is NOT AN ARMSTRONG", n);
        //    }
        //}



        //IMPROVED VERSION

        // Function to check Armstrong number
        static bool IsArmstrong(int n)
        {
            int temp = n;
            int digits = 0;

            // Count digits
            while (temp != 0)
            {
                digits++;
                temp /= 10;
            }

            temp = n;
            int sum = 0;

            while (temp != 0)
            {
                int rem = temp % 10;
                sum += Power(rem, digits);
                temp /= 10;
            }

            return sum == n;
        }
            
        // Separate power function (no Math.Pow)
        static int Power(int baseVal, int exponent)
        {
            int result = 1;

            while (exponent != 0)
            {
                result *= baseVal;
                exponent--;
            }

            return result;
        }

        public void checkArmstrongNumber()
        {
            Console.WriteLine("Enter Any Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (IsArmstrong(n) == true)
            {
                Console.WriteLine($"{n} is Armstrong");
            }
            else
            {
                Console.WriteLine($"{n} is NOT Armstrong");
            }

        }


        //#########################################################################################################################################


        //BASIC VERSION
        public void printArmstrongNumbers()
        {
            for (int n = 1; n <= 1000; n++)
            {
                int temp = n;
                int digits = 0;

                while (temp != 0)
                {
                    digits++;
                    temp /= 10;
                }

                temp = n;
                int sum = 0;

                while (temp != 0)
                {
                    int rem = temp % 10;

                    // METHOD 1: Manual power calculation

                    int result = 1;
                    int baseVal = rem;
                    int exponent = digits;

                    while (exponent != 0)
                    {
                        result = result * baseVal;
                        exponent--;
                    }

                    //sum = sum + result;

                    // METHOD 2: Using Math.Pow method
                    //sum = sum + (int)Math.Pow(rem, pow);

                    temp /= 10;
                }

                if (sum == n)
                {
                    Console.WriteLine(n);
                }
            }
        }



        //IMPROVED VERSION

        //// Function to check Armstrong number
        //static bool IsArmstrong(int n)
        //{
        //    int temp = n;
        //    int digits = 0;

        //    // Count digits
        //    while (temp != 0)
        //    {
        //        digits++;
        //        temp /= 10;
        //    }

        //    temp = n;
        //    int sum = 0;

        //    while (temp != 0)
        //    {
        //        int rem = temp % 10;
        //        sum += Power(rem, digits);
        //        temp /= 10;
        //    }

        //    return sum == n;
        //}

        //// Separate power function (no Math.Pow)
        //static int Power(int baseVal, int exponent)
        //{
        //    int result = 1;

        //    while (exponent != 0)
        //    {
        //        result *= baseVal;
        //        exponent--;
        //    }

        //    return result;
        //}

        //public void printArmstrongNumbers()
        //{
        //    for (int n = 1; n <= 1000; n++)
        //    {
        //        if (IsArmstrong(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }

        //}

        //#########################################################################################################################################



        public void addWithoutPlusSign()
        {
            int a = 5, b = 3;

            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            Console.WriteLine(a);
        }

        //#########################################################################################################################################




    }
}
