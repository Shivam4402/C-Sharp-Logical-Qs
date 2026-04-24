using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class StringPrograms
    {

        public void printStringCharLineByLine()
        {
            string str = "Welcome Home";

            Console.WriteLine("Original String: "+str);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

        //[OUTPUT]:

        //Original String: Welcome Home
        //W
        //e
        //l
        //c
        //o
        //m
        //e

        //H
        //o
        //m
        //e


        //#########################################################################################################################################



        public void printStringWithoutSpace()
        {
            string str = "Welcome To Pune";
            string msg = "";

            Console.WriteLine("Original String: "+str);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    msg = msg + str[i];
                }
            }

            Console.WriteLine(msg);
        }

        //[OUTPUT]:

        //Original String: Welcome To Pune
        //WelcomeToPune

        //#########################################################################################################################################



        public void printEachWordOfStringLineByLine()
        {
            string str = "Welcome To Pune";
            string msg = "";

            Console.WriteLine("Original String: "+str);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    msg = msg + str[i];
                }
                else
                {
                    Console.WriteLine(msg);
                    msg = "";
                }
            }

            Console.WriteLine(msg);

        }

        //[OUTPUT]:

        //Original String: Welcome To Pune
        //Welcome
        //To
        //Pune

        //#########################################################################################################################################



        public void printEachWordOfStringInReverse()
        {
            string str = "Welcome To Pune";
            string msg = "";

            Console.WriteLine("Original String: "+str);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    msg = str[i] + msg;
                }
                else
                {
                    Console.Write(msg + " ");
                    msg = "";
                }
            }
            Console.WriteLine(msg);
        }

        //[OUTPUT]:

        //Original String: Welcome To Pune
        //emocleW oT enuP

        //#########################################################################################################################################



        public void printEntireStringInReverse()
        {
            string str = "Welcome To Pune";
            string msg = "";

            Console.WriteLine("Original String: "+str);

            //SIMPLE LOGIC

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }


            //COMPLEX LOGIC

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    if (str[i] != ' ')
            //    {
            //        msg = msg + str[i];
            //    }
            //    else
            //    {
            //        Console.Write(msg + " ");
            //        msg = "";

            //    }
            //}

            //Console.WriteLine(msg);
        }

        //[OUTPUT]:

        //Original String: Welcome To Pune
        //enuP oT emocleW

        //#########################################################################################################################################



        public void printStringWordsInReverseOrder()
        {
            string str = "Welcome To Pune";
            string msg = "";

            Console.WriteLine("Original String: " + str);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    msg = str[i] + msg;
                }
                else
                {
                    Console.Write(msg + " ");
                    msg = "";
                }
            }

            Console.WriteLine(msg);
        }

        //[OUTPUT]:

        //Original String: Welcome To Pune
        //Pune To Welcome

        //#########################################################################################################################################



        public void printDistinctCharFromString()
        {

            //string str = "Welcome_To_Pune";

            //char[] msg = new char[str.Length];

            //int k = 0;

            //for (int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;

            //    for (int j = 0; j < k; j++)
            //    {
            //        if (str[i] == msg[j])
            //        {
            //            count++;
            //            break;
            //        }
            //    }

            //    if (count == 0)
            //    {
            //        msg[k] = str[i];
            //        k++;
            //    }
            //}

            //Console.WriteLine("Distinct Characters From String:");

            //for (int i = 0; i < k; i++)
            //{
            //    Console.Write(msg[i] + " ");

            //}



            //SIMPLE LOGIC

            string str = "Welcome To Pune";
            string msg = "";

            Console.WriteLine("Original String: " + str);

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < msg.Length; j++)
                {
                    if (str[i] == msg[j])
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    msg = msg + str[i];
                }

            }

            Console.WriteLine(msg);




        }

        //[OUTPUT]:

        //Distinct Characters From String:
        //W e l c o m _ T P u n

        //#########################################################################################################################################



        public void PalindromeCheckWithoutReverse()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            bool isPalindrome = true;

            for (int i = 0; i <= str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome == true)
            {
                Console.WriteLine("String is Palindrome.");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome.");
            }
        }

        //#########################################################################################################################################

    

        public void checkIdenticalStringIrrespectiveOfTheirCase()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();



            //Simple way to check for identical strings irrespective of case    

            //if (str1.ToLower() == str2.ToLower())
            //{
            //    Console.WriteLine("Strings are identical.");
            //}
            //else
            //{
            //    Console.WriteLine("Strings are not identical.");
            //}



            //Without using inbuilt function

            int count = 0;
            char a, b;
            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    a = str1[i];
                    b = str2[i];
                    if (a >= 'A' && a <= 'Z')
                    {
                        a = (char)(a + 32);
                    }
                    if (b >= 'A' && b <= 'Z')
                    {
                        b = (char)(b + 32);
                    }
                    if (a == b)
                    {
                        count++;
                    }
                }

                if (count == str1.Length)
                {
                    Console.WriteLine("Strings are identical.");
                }
                else
                {
                    Console.WriteLine("Strings are not identical.");
                }
            }

        }

        //#########################################################################################################################################




        public void camelCase()
        {
            string str = "welcome to pune";

            string msg = "";

            Console.WriteLine("Original String: " + str);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    msg = msg + str[i];

                }
                else
                {
                    char ch = str[i + 1];

                    if (ch >= 'a' && ch <= 'z') // lowercase check
                    {
                        ch = (char)(ch - 32); // uppercase banaya
                    }

                    msg = msg + ch;
                    i++; // skip next character
                }

            }
            Console.WriteLine("Camel Case String: " + msg);
        }

        //[OUTPUT]:

        //Original String: welcome to pune
        //Camel Case String: welcomeToPune

        //#########################################################################################################################################




        public void upperCaseWithoutBuiltIn()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch >= 'a' && ch <= 'z')
                {

                    ch = (char)(ch - 32);
                }

                result += ch;
            }

            Console.WriteLine("Uppercase string: " + result);
        }

        //#########################################################################################################################################



        public void lowerCaseWithoutBuiltIn()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch >= 'A' && ch <= 'Z')
                {

                    ch = (char)(ch + 32);
                }

                result += ch;
            }

            Console.WriteLine("Lowercase string: " + result);
        }

        //#########################################################################################################################################




        public void countOfVowelInString()
        {
            string str = "Welcome to Pune";

            int vowels = 0;
            int consonants = 0;

            str = str.ToLower();

            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);



            //✅ LINQ Version (Vowels & Consonants)

            //string str = "Welcome to Pune";

            //var vowels = "aeiou";

            //str = str.ToLower();

            //int vowelCount = str.Count(c => vowels.Contains(c));
            //int consonantCount = str.Count(c => char.IsLetter(c) && !vowels.Contains(c));

            //Console.WriteLine("Vowels: " + vowelCount);
            //Console.WriteLine("Consonants: " + consonantCount);

        }

        //#########################################################################################################################################




        public void stringPartWithBuiltIn()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            if (str2.Contains(str1))
            {
                Console.WriteLine("Yes, the first string is part of the second string.");
            }
            else
            {
                Console.WriteLine("No, the first string is not part of the second string.");
            }
        }

        //#########################################################################################################################################





        public void stringPartWithOutBuiltIn()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            bool found = false;

            // Loop karte hain str2 ke andar
            for (int i = 0; i <= str2.Length - str1.Length; i++)
            {
                int j;
                // str1 ka har character check karte hain str2 ke ek part se
                for (j = 0; j < str1.Length; j++)
                {
                    if (str2[i + j] != str1[j])
                    {
                        break; // agar koi character match nahi hua toh break
                    }
                }

                // agar pura str1 match ho gaya
                if (j == str1.Length)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Yes, the first string is part of the second string.");
            }
            else
            {
                Console.WriteLine("No, the first string is not part of the second string.");
            }
        }

        //#########################################################################################################################################



        public void longestWordOfString()
        {

            string input = "Welcome To Home";
            string[] words = input.Split(' ');

            string biggestWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > biggestWord.Length)
                {
                    biggestWord = words[i];
                }
            }

            Console.WriteLine($"Biggest Word : \"{biggestWord}\"");
        }

        //[INPUT]:
        //Welcome to pune

        //[OUTPUT]:
        //Biggest Word : "Welcome"

        //#########################################################################################################################################



        public void splitStringDemo()
        {
            string str = "Welcome to pune";
            string[] data = str.Split();

            foreach (string d in data)
            {
                Console.WriteLine(d);
            }

            //for (int i=0; i<data.Length; i++ ) 
            //{
            //    Console.WriteLine(data[i]);
            //}

        }

        //[INPUT]:
        //Welcome to pune

        //[OUTPUT]:
        //Welcome
        //to
        //pune

        //#########################################################################################################################################




        public void stringPartFromArrayOfString()
        {

            string[] cities = { "pune", "mumbai", "nagpur", "solapur", "kolhapur" };

            Console.WriteLine("Enter the statment");
            string input = Console.ReadLine().ToLower();

            bool found = false;

            //Using for loop, we can check if the input is present in the array of cities

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i] == input)
                {
                    found = true;
                    break;
                }
            }

            //Without using for loop, we can use foreach loop to check if the input is present in the array of cities

            //foreach (string data in cities)
            //{
            //    if (data.Contains(input))
            //    {
            //        found = true;
            //        break;
            //    }
            //}


            if (found)
            {
                Console.WriteLine($"Yes, \"{input}\" City is present.");
            }
            else
            {
                Console.WriteLine($"No, \"{input}\" City is not present.");
            }

        }

        //#########################################################################################################################################



        public void findAllSubstring()
        {
            string str = "abcd";

            for (int i = 0; i < str.Length; i++)
            {
                string temp = "";

                for (int j = i; j < str.Length; j++)
                {
                    temp = temp + str[j];
                    Console.Write(temp + " ");
                }
            }

        }

        //[INPUT]:
        //abcd

        //[OUTPUT]:
        //a ab abc abcd b bc bcd c cd d

        //#########################################################################################################################################


        public void countOccuranceOfEachChar()
        {
            string str = "Welcome To Pune";

            int[] visited = new int[str.Length]; // 0 means not counted yet
            Console.WriteLine("\nElement frequencies:");

            for (int i = 0; i < str.Length; i++)
            {
                if (visited[i] == 1 || str[i] == ' ')
                    continue; // Already counted, skip

                int count = 1;

                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                        visited[j] = 1; // mark as counted
                    }
                }

                Console.WriteLine(str[i] + " occurs " + count + " time(s)");
            }

        }
        //[OUTPUT]:

        //Element frequencies:
        //W occurs 1 time(s)
        //e occurs 3 time(s)
        //l occurs 1 time(s)
        //c occurs 1 time(s)
        //o occurs 2 time(s)
        //m occurs 1 time(s)
        //E occurs 1 time(s)
        //P occurs 1 time(s)
        //u occurs 1 time(s)
        //n occurs 1 time(s)

        //#########################################################################################################################################


        
        public void countNumberOfWordsInString()
        {
            string str = "Welcome To Pune";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Number of words in the string: " + (count + 1));



            //✅ Method 2: Using Split(Most common)

            //string str = "Welcome to Pune City";

            //string[] words = str.Split(' ');

            //Console.WriteLine("Word count: " + words.Length);
        }

        //#########################################################################################################################################



    }
}
