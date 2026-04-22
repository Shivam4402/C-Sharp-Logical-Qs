using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WhileLoop
    {
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
            Console.WriteLine("Transpose:"+transpose);
        }



    }
}
