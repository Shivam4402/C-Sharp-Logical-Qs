using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NestedArray
    {
        public void basicNestedArrayPrint()
        {
            //USER INPUT FOR 2D ARRAY

            //int[,] a = new int[3, 3];

            //Console.WriteLine("Enter 3 x 3 Matrix");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}


            //HARDCODED 2D ARRAY

            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            Console.WriteLine("Your Matrix Array is:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        //[OUTPUT]:

        //Your Matrix Array is:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //#########################################################################################################################################




        public void additionOfTwoMatrices()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] c = new int[3, 3];


            Console.WriteLine("Addition Of Two Matrices:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];

                    Console.Write(c[i, j] + " ");
                }

                Console.WriteLine();
            }

        }

        //[OUTPUT]:

        //[INPUT]:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //Addition Of Two Matrices:
        //2 4 6 
        //8 10 12 
        //14 16 18 

        //#########################################################################################################################################




        public void printEvenNumbersFromMatrix()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Even Numbers From Matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:

        //[INPUT]:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //Even Numbers From Matrix:
        // 2  
        //4  6 
        // 8  

        //#########################################################################################################################################




        public void printDiagonalMatrixArray()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Diagonal Matrix Array:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }

        //[OUTPUT]:

        //[INPUT]:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //Diagonal Matrix Array:
        //1   
        // 5  
        //  9 


        //#########################################################################################################################################



        public void printTransposeMatrix()
        {
            int [,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Transpose Matrix Array:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[j, i] + " ");

                }
                Console.WriteLine();
            }
        }

        //[OUTPUT]:

        //[INPUT]:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //Transpose Matrix Array:
        //1 4 7 
        //2 5 8 
        //3 6 9 

        //#########################################################################################################################################



        public void printAdditionOfEachRowOfMatrix()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Addition Of Each Row Of Matrix:");

            for (int i = 0; i < 3; i++)
            {
                int rowsum = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                    rowsum = a[i, j] + rowsum;

                }

                Console.WriteLine(rowsum);
            }

        }

        //[OUTPUT]:

        //[INPUT]:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //Addition Of Each Row Of Matrix:
        //1 2 3 6
        //4 5 6 15
        //7 8 9 24

        //#########################################################################################################################################




        public void convertOneDtoTwoDArray()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("1D Array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            int size= a.Length;

            Console.WriteLine();

            Console.WriteLine("Enter Rows to Convert 1D Array to 2D Array");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Columns to Convert 1D Array to 2D Array");
            int columns = Convert.ToInt32(Console.ReadLine());

            if (rows * columns > size)
            {
                Console.WriteLine("Invalid Input");
                return;
            }


            int[,] b = new int[rows, columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    b[i, j] = a[index];

                    index++;

                }
            }
            Console.WriteLine("2D Array:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        //[OUTPUT]:

        //1D Array:
        //1 2 3 4 5 6 7 8 9 
        //Enter Rows to Convert 1D Array to 2D Array
        //3
        //Enter Columns to Convert 1D Array to 2D Array
        //3
        //2D Array:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //#########################################################################################################################################




        public void convertTwoDtoOneDArray()
        {
  
            int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int rows = arr2D.GetLength(0); // number of rows
            int cols = arr2D.GetLength(1); // number of columns

            int[] arr1D = new int[rows * cols];
            int index = 0;

            // Column-wise traversal

            //for (int col = 0; col < cols; col++)
            //{
            //    for (int row = 0; row < rows; row++)
            //    {
            //        arr1D[index] = arr2D[row, col];
            //        index++;
            //    }
            //}

            //Console.WriteLine("1D Array (column-wise):");
            //for (int i = 0; i < arr1D.Length; i++)
            //{
            //    Console.Write(arr1D[i] + " ");
            //}

            // Row-wise traversal

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    arr1D[index] = arr2D[row, col];
                    index++;
                }
            }

            Console.WriteLine("1D Array (row-wise):");
            for (int i = 0; i < arr1D.Length; i++)
            {
                Console.Write(arr1D[i] + " ");
            }

        }

        //[INPUT]:
        //1 2 3 
        //4 5 6 
        //7 8 9 

        //[OUTPUT]:
        //1D Array(row-wise) :
        //1 2 3 4 5 6 7 8 9 

        //#########################################################################################################################################











    }
}
