using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Real_Interview_Qs
    {

        //Qs 1. Write an Async Method to Call 3 APIs in Parallel ?

        //[SOLUTION]:

        //using System;
        //using System.Net.Http;
        //using System.Threading.Tasks;

        //public class ApiService
        //    {
        //        private readonly HttpClient _client = new HttpClient();

        //        public async Task CallApisAsync()
        //        {
        //            try
        //            {
        //                Task<string> usersTask =
        //                    GetApiDataAsync("https://api.example.com/users");

        //                Task<string> productsTask =
        //                    GetApiDataAsync("https://api.example.com/products");

        //                Task<string> ordersTask =
        //                    GetApiDataAsync("https://api.example.com/orders");

        //                await Task.WhenAll(usersTask, productsTask, ordersTask);

        //                Console.WriteLine(await usersTask);
        //                Console.WriteLine(await productsTask);
        //                Console.WriteLine(await ordersTask);
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine($"Error: {ex.Message}");
        //            }
        //        }

        //        private async Task<string> GetApiDataAsync(string url)
        //        {
        //            HttpResponseMessage response = await _client.GetAsync(url);

        //            response.EnsureSuccessStatusCode();

        //            return await response.Content.ReadAsStringAsync();
        //        }
        //    }


        //#########################################################################################################################################




        //Qs 2. // Write a program to find first 3 vowels in a given string. 
        // print the 1st vowel with , the 2nd vowel with *, the 3rd vowel with *  

        //[INPUT]: Education
        //[OUTPUT]:   e,
        //            u*,
        //            a*

        //[SOLUTION]:
        public void vowelPrint()
        {
            string str = "Education";
            int count = 0;

            foreach (char ch in str.ToLower())
            {
                if ("aeiou".Contains(ch))
                {
                    count++;

                    if (count == 1)
                        Console.WriteLine(ch + ",");
                    else if (count == 2)
                        Console.WriteLine(ch + "*,");
                    else if (count == 3)
                    {
                        Console.WriteLine(ch + "*");
                        break;
                    }
                }
            }
        }


        //#########################################################################################################################################




        //Qs 3.  // Replace the null with previous integer occurrence in the input array. 
        // If all the previous values are null then take the last occurred integer value in the array.

        //[INPUT]:  [null, null, 5, null, 7, null, null]
        //[OUTPUT]: [7, 7, 5, 5, 7, 7, 7]

        //[SOLUTION]:
        public void nullReplacement()
        {
            int?[] arr = { null, null, 5, null, 7, null, null };

            // Find last occurred integer value
            int lastValue = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != null)
                {
                    lastValue = arr[i].Value;
                    break;
                }
            }

            int previousValue = lastValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = previousValue;
                }
                else
                {
                    previousValue = arr[i].Value;
                }
            }

            // Print result
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }


        //#########################################################################################################################################




        //Qs 4. Print the count of no.of distinct even numbers in the array.

        //[INPUT]:  [2, 3, 4, 4, 5, 6, 7, 8, 8, 8, 3 ]
        //[OUTPUT]: Distinct Even Numbers Count: 4

        //[SOLUTION 1]:

        public void countOfEvenDistinctNo()
        {
            int[] arr = { 2, 3, 4, 4, 5, 6, 7, 8, 8, 8, 3 };

            int count = arr
                        .Where(x => x % 2 == 0) // even numbers
                        .Distinct()             // unique values
                        .Count();               // count

            Console.WriteLine("Distinct Even Numbers Count: " + count);
        }

        //[SOLUTION 2]: 

        public void countOfEvenDistinctNo_()
        {
            int[] arr = { 2, 3, 4, 4, 5, 6, 7, 8, 8, 8, 3 };

            HashSet<int> evenNumbers = new HashSet<int>();

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            Console.WriteLine("Count: " + evenNumbers.Count);
        }


        //#########################################################################################################################################




        // Qs 5. Print the output of this array input in pairs: [a, a, a, b, b, c, d, e, e, a, b], where the consequent variable is not equal to the previous variable
        //[INPUT]:  [a, a, a, b, b, c, d, e, e, a, b]
        //[OUTPUT]:   a
        //            b
        //            c
        //            d
        //            e
        //            a
        //            b

        public void differConsequent()
        {
            char[] arr = { 'a', 'a', 'a', 'b', 'b', 'c', 'd', 'e', 'e', 'a', 'b' };

            Console.WriteLine(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }


        //#########################################################################################################################################

    }
}
