using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array
    {
        public void basicArrayPrint()
        {
            int[] a = { 1, 5, 6, 8, 9 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        //#########################################################################################################################################



        public void arrayUserInput()
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 values");


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("My Array Is:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        //#########################################################################################################################################



        public void additionOfElementsOfArray()
        {
            int[] a = { 1, 5, 6, 8, 9 };

            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }

            Console.WriteLine("Addition Of Each Element Of An Array is:" + sum);
        }

        //#########################################################################################################################################




        public void printPrimeNumbersFromArray()
        {
            int[] a = { 4, 5, 6, 7, 10, 11, 13, 15, 17 };


            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;

                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(a[i]);
                }

            }
        }

        //#########################################################################################################################################



        public void printPalindromeNumbersFromArray()
        {
            int[] a = { 7, 10, 11, 13, 15, 17, 191, 202, 212, 222 };

            for (int i = 0; i < a.Length; i++)
            {
                int rev = 0;
                int temp = a[i];

                while (temp != 0)
                {
                    int rem = temp % 10;
                    rev = rem + rev * 10;
                    temp = temp / 10;
                }

                if (a[i] == rev)
                {
                    Console.WriteLine("PALINDROME: " + a[i]);
                }

            }
        }

        //#########################################################################################################################################



        public void findGreatestNumFromArray()
        {
            int[] a = { 1, 5, 6, 8, 9, 2, 3, 7 };

            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("Greatest Number From An Array is: " + max);
        }


        //#########################################################################################################################################



        public void findSecondGreatestNumFromArray()
        {
            int[] a = { 1, 5, 6, 8, 9, 2, 3, 7 };

            int max1 = a[0];
            int max2 = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }

                if (a[i] < max1 && a[i] > max2)
                {
                    max2 = a[i];
                }

            }

            Console.WriteLine("Greatest Value= " + max1);
            Console.WriteLine("Second Greatest Value= " + max2);

        }

        //#########################################################################################################################################



        public void ascendingOrderArray()
        {
            int[] a = { 1, 5, 6, 8, 9, 2, 3, 7 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }

            Console.WriteLine("Ascending Array is: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        //#########################################################################################################################################



        public void countOfOccuranceOfElementsInArray()
        {
            int[] a = { 5, 3, 5, 2, 3, 4, 1 };

            int[] visited = new int[a.Length]; // 0 means not counted yet

            Console.WriteLine("Element frequencies:");

            for (int i = 0; i < a.Length; i++)
            {
                if (visited[i] == 1)
                    continue; // Already counted, skip

                int count = 1;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        visited[j] = 1; // mark as counted
                    }
                }

                Console.WriteLine(a[i] + " occurs " + count + " time(s)");
            }

        }

        //#########################################################################################################################################



        public void mergeTwoArray()
        {
            int[] a = { 5, 3, 7, 2, 3 };

            int[] b = { 1, 4, 6, 8 };


            int[] c = new int[a.Length + b.Length];


            for (int i = 0; i < c.Length; i++)
            {
                if (i < a.Length)
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = b[i - a.Length];
                }

            }

            Console.WriteLine("Merged Array IS :");

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

        }

        //#########################################################################################################################################




        public void distinctArrayValues()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            int[] temp = new int[arr.Length];
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < k; j++)
                {
                    if (arr[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp[k] = arr[i];
                    k++;
                }
            }

            Console.WriteLine("Distinct Array is:");

            for (int i = 0; i < k; i++)
            {
                Console.Write(temp[i] + " ");
            }



            //Method 1: Using LINQ(Simplest)

            //int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            //int[] result = arr.Distinct().ToArray();

            //foreach (int num in result)
            //{
            //    Console.Write(num + " ");
            //}



            //Method 3: Using HashSet (Best for performance)

            //int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            //HashSet<int> set = new HashSet<int>(arr);

            //foreach (int num in set)
            //{
            //    Console.Write(num + " ");
            //}

        }

        //#########################################################################################################################################



        public void printMatchingValuesFromArray()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 3, 4, 9 };

            Console.WriteLine("Matching values:");

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                        break; 
                    }
                }
            }

        }

        //#########################################################################################################################################


        public void leftCircularRotationArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            // Left circular rotation by 1 time

            int temp = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = temp;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


            // Another way to do left circular rotation by d times

            //int n = arr.Length;
            //int d = 2; // number of rotations

            //int[] result = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    result[i] = arr[(i + d) % n];
            //}

            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}

        }

        //input: 1 2 3 4 5
        //output: 2 3 4 5 1

        //#########################################################################################################################################




        void rightCircularRotationArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };


            // Right circular rotation by 1 time
            int temp = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = temp;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


            // Another way to do right circular rotation by d times

            //int n = arr.Length;
            //int d = 2; // number of rotations

            //int[] result = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    result[(i + d) % n] = arr[i];
            //}

            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}

        }

        //input: 1 2 3 4 5
        //output: 5 1 2 3 4

        //#########################################################################################################################################


        public void finfThirdGreatestElementFromArray()
        {
            int[] a = { 3, 2, 1, 5, 4 };

            int Max = a[0];
            int Max2 = a[0];
            int Max3 = a[0];

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > Max)
                {
                    Max3 = Max2;
                    Max2 = Max;
                    Max = a[i];
                }
                else if (a[i] > Max2 && a[i] != Max)
                {
                    Max3 = Max2;
                    Max2 = a[i];
                }
                else if (a[i] > Max3 && a[i] != Max2 && a[i] != Max)
                {
                    Max3 = a[i];
                }
            }

            Console.WriteLine("Third largest number is: " + Max3);


            //LINQ method to find the third largest number in an array

            //int[] arr = { 12, 45, 45, 1, 67, 34, 89, 89, 23 };

            //int thirdLargest = arr
            //    .Distinct()
            //    .OrderByDescending(x => x)
            //    .Skip(2)
            //    .First();

            //Console.WriteLine("Third largest: " + thirdLargest);

        }

        //input: 3 2 1 5 4
        //output: 3

        //#########################################################################################################################################




        public void reverseArray()
        {
            //✅ Method 1: Using Two Pointers (Most important for interviews)

            int[] arr = { 1, 2, 3, 4, 5 };

            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



            //✅ Method 2 : Using built-in Array.Reverse(Simplest)

            //int[] arr = { 1, 2, 3, 4, 5 };

            //Array.Reverse(arr);

            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}


            //✅ Method 3: Using Extra Array

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] rev = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    rev[i] = arr[arr.Length - 1 - i];
            //}

            //foreach (int num in rev)
            //{
            //    Console.Write(num + " ");
            //}

        }

        //#########################################################################################################################################


        public void findMissingNumberInArray()
        {
            int[] arr = { 1, 2, 4, 5, 6 }; // Missing number is 3
            int n = arr.Length + 1; // Total numbers including the missing one
            int expectedSum = n * (n + 1) / 2; // Sum of first n natural numbers
            int actualSum = arr.Sum(); // Sum of elements in the array
            int missingNumber = expectedSum - actualSum;
            Console.WriteLine("Missing number is: " + missingNumber);
        }

        //#########################################################################################################################################


        public void primeNonPrimeArray()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // temporary arrays (same size as input)
            int[] prime = new int[arr.Length];
            int[] nonPrime = new int[arr.Length];

            int pIndex = 0;
            int npIndex = 0;

            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    prime[pIndex] = num;
                    pIndex++;
                }
                else
                {
                    nonPrime[npIndex] = num;
                    npIndex++;
                }
            }

            // Print prime numbers
            Console.WriteLine("Prime numbers:");
            for (int i = 0; i < pIndex; i++)
            {
                Console.Write(prime[i] + " ");
            }

            Console.WriteLine();

            // Print non-prime numbers
            Console.WriteLine("Non-Prime numbers:");
            for (int i = 0; i < npIndex; i++)
            {
                Console.Write(nonPrime[i] + " ");
            }

            // Prime check function
            bool IsPrime(int n)
            {
                if (n <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }

                return true;
            }
        }

        //#########################################################################################################################################


        public void swapArrayPositions()
        {

            int[] arr = { 10, 20, 30, 40, 50 };

            Console.Write("Enter first position: ");
            int pos1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second position: ");
            int pos2 = int.Parse(Console.ReadLine());

            int i = pos1 - 1;
            int j = pos2 - 1;

            // Validate input
            if (i >= 0 && j >= 0 && i < arr.Length && j < arr.Length)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                Console.WriteLine("Array after swapping:");

                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid positions!");
            }
        }

        //#########################################################################################################################################


        public void interleavingMergeOfTwoArrays()
        {

            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };

            int[] c = new int[a.Length + b.Length];

            int k = 0;

            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }

            foreach (int num in c)
            {
                Console.Write(num + " ");
            }

        }

        //[INPUT]:
        //a = { 1, 2, 3 }
        //b = { 1, 2, 3 }

        //[OUTPUT]:
        //1 1 2 2 3 3

        //#########################################################################################################################################



    }
}
