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

        static void Main(string[] args)
        {

            Program program = new Program();



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

            //Console.WriteLine("print9Series");
            //b.print9Series();
            //Console.WriteLine();



            //#########################################################################################################################################



            ForLoop f = new ForLoop();

            //Console.WriteLine("printMessageWithoutSemicolon");
            //f.printMessageWithoutSemicolon();
            //Console.WriteLine();

            //Console.WriteLine("multiplyWithoutStarOperator");
            //f.multiplyWithoutStarOperator();
            //Console.WriteLine();

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

            //Console.WriteLine("CheckSemiPrimeOrNot");
            //f.CheckSemiPrimeOrNot();
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

            //OUTPUT:
            //1 2 3 4 5
            //6 7 8 9 10
            //11 12 13 14 15
            //16 17 18 19 20
            //21 22 23 24 25

            //Console.WriteLine("pattern2");
            //pt.pattern2();
            //Console.WriteLine();

            //OUTPUT:
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5

            //Console.WriteLine("pattern3");
            //pt.pattern3();
            //Console.WriteLine();

            //OUTPUT:
            //1
            //2 2
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5

            //Console.WriteLine("pattern4");
            //pt.pattern4();
            //Console.WriteLine();

            //OUTPUT:
            //1 2 3 4 5
            //1 2 3 4
            //1 2 3
            //1 2
            //1

            //Console.WriteLine("pattern5");
            //pt.pattern5();
            //Console.WriteLine();

            //OUTPUT:
            //5 4 3 2 1
            //5 4 3 2
            //5 4 3
            //5 4
            //5

            //Console.WriteLine("pattern6");
            //pt.pattern6();
            //Console.WriteLine();

            //OUTPUT:
            //5
            //5 4
            //5 4 3
            //5 4 3 2
            //5 4 3 2 1

            //Console.WriteLine("pattern7");
            //pt.pattern7();
            //Console.WriteLine();

            //OUTPUT:

            //        1
            //      2 1
            //    3 2 1
            //  4 3 2 1
            //5 4 3 2 1


            //Console.WriteLine("pattern8");
            //pt.pattern8();
            //Console.WriteLine();

            //OUTPUT:

            //        1
            //      2 1 2
            //    3 2 1 2 3
            //  4 3 2 1 2 3 4
            //5 4 3 2 1 2 3 4 5

            //Console.WriteLine("pattern9");
            //pt.pattern9();
            //Console.WriteLine();

            //OUTPUT:
            //5 4 3 2 1
            //4 3 2 1
            //3 2 1
            //2 1
            //1


            //#########################################################################################################################################


            PatternsBySheryians ps = new PatternsBySheryians();

            //[YOUTUBE CHANNEL]: Sheryians Coding School
            //[YOUTUBE LINK]: https://www.youtube.com/watch?v=NaRPbIXRwhE&list=PLbtI3_MArDOmSKABu09sEs0SxCibd1wgr&index=7


            //Console.WriteLine("pattern1");
            //ps.pattern1();
            //Console.WriteLine();

            //[OUTPUT]:
            //*****
            //*****
            //*****
            //*****
            //*****

            //Console.WriteLine("pattern2");
            //ps.pattern2();
            //Console.WriteLine();

            //[OUTPUT]:
            //*
            //**
            //***
            //****
            //*****

            //Console.WriteLine("pattern3");
            //ps.pattern3();
            //Console.WriteLine();

            //[OUTPUT]:
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5

            //Console.WriteLine("pattern4");
            //ps.pattern4();
            //Console.WriteLine();

            //[OUTPUT]:
            //A
            //A B
            //A B C
            //A B C D
            //A B C D E

            //Console.WriteLine("pattern5");
            //ps.pattern5();
            //Console.WriteLine();

            //[OUTPUT]:
            //*****
            //****
            //***
            //**
            //*

            //Console.WriteLine("pattern6");
            //ps.pattern6();
            //Console.WriteLine();

            //[OUTPUT]:
            //        *
            //      **
            //    ***
            //  ****
            //*****

            //Console.WriteLine("pattern7");
            //ps.pattern7();
            //Console.WriteLine();

            //[OUTPUT]:
            //    *
            //   ***
            //  *****
            // *******
            //*********

            //Console.WriteLine("pattern8");
            //ps.pattern8();
            //Console.WriteLine();

            //[OUTPUT]:
            //        *
            //      @@
            //    ***
            //  @@@@
            //*****

            //Console.WriteLine("pattern9");
            //ps.pattern9();
            //Console.WriteLine();

            //[OUTPUT]:
            //*****
            //*   *
            //*   *
            //*   *
            //*****

            //Console.WriteLine("pattern10");
            //ps.pattern10();
            //Console.WriteLine();

            //[OUTPUT]:
            //  *****
            //      *
            //    *
            //  *
            //*****

            //Console.WriteLine("patternX");
            //ps.patternX();
            //Console.WriteLine();

            //Console.WriteLine("patternV");
            //ps.patternV();
            //Console.WriteLine();




            //#########################################################################################################################################


            WhileLoop w = new WhileLoop();

            //Console.WriteLine("countOfDigit");
            //w.countOfDigit();
            //Console.WriteLine();

            //Console.WriteLine("sumOfDigits");
            //w.sumOfDigits();
            //Console.WriteLine();

            //Console.WriteLine("reverseOfNumber");
            //w.reverseOfNumber();
            //Console.WriteLine();

            //Console.WriteLine("checkPalindromeNumber");
            //w.checkPalindromeNumber();
            //Console.WriteLine();

            //Console.WriteLine("binaryToDecimal");
            //w.binaryToDecimal();
            //Console.WriteLine();

            //Console.WriteLine("decimalToBinary");
            //w.decimalToBinary();
            //Console.WriteLine();

            //Console.WriteLine("printBinaryOfOneToHundred");
            //w.printBinaryOfOneToHundred();
            //Console.WriteLine();

            //Console.WriteLine("checkArmstrongNumber");
            //w.checkArmstrongNumber();
            //Console.WriteLine();

            //Console.WriteLine("printArmstrongNumbers");
            //w.printArmstrongNumbers();
            //Console.WriteLine();

            //Console.WriteLine("addWithoutPlusSign");
            //w.addWithoutPlusSign();
            //Console.WriteLine();




            //#########################################################################################################################################


            Array arr = new Array();

            //Console.WriteLine("basicArrayPrint");
            //arr.basicArrayPrint();
            //Console.WriteLine();

            //Console.WriteLine("arrayUserInput");
            //arr.arrayUserInput();
            //Console.WriteLine();

            //Console.WriteLine("additionOfElementsOfArray");
            //arr.additionOfElementsOfArray();
            //Console.WriteLine();

            //Console.WriteLine("printPrimeNumbersFromArray");
            //arr.printPrimeNumbersFromArray();
            //Console.WriteLine();

            //Console.WriteLine("printPalindromeNumbersFromArray");
            //arr.printPalindromeNumbersFromArray();
            //Console.WriteLine();

            //Console.WriteLine("findGreatestNumFromArray");
            //arr.findGreatestNumFromArray();
            //Console.WriteLine();

            //Console.WriteLine("findSecondGreatestNumFromArray");
            //arr.findSecondGreatestNumFromArray();
            //Console.WriteLine();

            //Console.WriteLine("countOfOccuranceOfElementsInArray");
            //arr.countOfOccuranceOfElementsInArray();
            //Console.WriteLine();

            //Console.WriteLine("mergeTwoArray");
            //arr.mergeTwoArray();
            //Console.WriteLine();

            //Console.WriteLine("distinctArrayValues");
            //arr.distinctArrayValues();
            //Console.WriteLine();

            //Console.WriteLine("printMatchingValuesFromArray");
            //arr.printMatchingValuesFromArray();
            //Console.WriteLine();

            //Console.WriteLine("leftCircularRotationArray");
            //arr.leftCircularRotationArray();
            //Console.WriteLine();

            //Console.WriteLine("rightCircularRotationArray");
            //arr.rightCircularRotationArray();
            //Console.WriteLine();

            //Console.WriteLine("findThirdGreatestElementFromArray");
            //arr.findThirdGreatestElementFromArray();
            //Console.WriteLine();

            //Console.WriteLine("reverseArray");
            //arr.reverseArray();
            //Console.WriteLine();

            //Console.WriteLine("findMissingNumberInArray");
            //arr.findMissingNumberInArray();
            //Console.WriteLine();

            //Console.WriteLine("primeNonPrimeArray");
            //arr.primeNonPrimeArray();
            //Console.WriteLine();

            //Console.WriteLine("swapArrayPositions");
            //arr.swapArrayPositions();
            //Console.WriteLine();

            //Console.WriteLine("interleavingMergeOfTwoArrays");
            //arr.interleavingMergeOfTwoArrays();
            //Console.WriteLine();



            //#########################################################################################################################################



            NestedArray na = new NestedArray();

            //Console.WriteLine("basicNestedArrayPrint");
            //na.basicNestedArrayPrint();
            //Console.WriteLine();

            //Console.WriteLine("additionOfTwoMatrices");
            //na.additionOfTwoMatrices();
            //Console.WriteLine();

            //Console.WriteLine("printEvenNumbersFromMatrix");
            //na.printEvenNumbersFromMatrix();
            //Console.WriteLine();

            //Console.WriteLine("printDiagonalMatrixArray");
            //na.printDiagonalMatrixArray();
            //Console.WriteLine();

            //Console.WriteLine("printTransposeMatrix");
            //na.printTransposeMatrix();
            //Console.WriteLine();

            //Console.WriteLine("printAdditionOfEachRowOfMatrix");
            //na.printAdditionOfEachRowOfMatrix();
            //Console.WriteLine();

            //Console.WriteLine("convertOneDtoTwoDArray");
            //na.convertOneDtoTwoDArray();
            //Console.WriteLine();

            //Console.WriteLine("convertTwoDtoOneDArray");
            //na.convertTwoDtoOneDArray();
            //Console.WriteLine();



            //#########################################################################################################################################



            StringPrograms sp = new StringPrograms();

            //Console.WriteLine("printStringCharLineByLine");
            //sp.printStringCharLineByLine();
            //Console.WriteLine();

            //Console.WriteLine("printStringWithoutSpace");
            //sp.printStringWithoutSpace();
            //Console.WriteLine();

            //Console.WriteLine("printEachWordOfStringLineByLine");
            //sp.printEachWordOfStringLineByLine();
            //Console.WriteLine();

            //Console.WriteLine("printEachWordOfStringInReverse");
            //sp.printEachWordOfStringInReverse();
            //Console.WriteLine();

            //Console.WriteLine("printEntireStringInReverse");
            //sp.printEntireStringInReverse();
            //Console.WriteLine();

            //Console.WriteLine("printStringWordsInReverseOrder");
            //sp.printStringWordsInReverseOrder();
            //Console.WriteLine();

            //Console.WriteLine("printDistinctCharFromString");
            //sp.printDistinctCharFromString();
            //Console.WriteLine();

            //Console.WriteLine("PalindromeCheckWithoutReverse");
            //sp.PalindromeCheckWithoutReverse();
            //Console.WriteLine();

            //Console.WriteLine("checkIdenticalStringIrrespectiveOfTheirCase");
            //sp.checkIdenticalStringIrrespectiveOfTheirCase();
            //Console.WriteLine();

            //Console.WriteLine("camelCase");
            //sp.camelCase();
            //Console.WriteLine();

            //Console.WriteLine("upperCaseWithoutBuiltIn");
            //sp.upperCaseWithoutBuiltIn();
            //Console.WriteLine();

            //Console.WriteLine("lowerCaseWithoutBuiltIn");
            //sp.lowerCaseWithoutBuiltIn();
            //Console.WriteLine();

            //Console.WriteLine("countOfVowelInString");
            //sp.countOfVowelInString();
            //Console.WriteLine();

            //Console.WriteLine("stringPartWithBuiltIn");
            //sp.stringPartWithBuiltIn();
            //Console.WriteLine();

            //Console.WriteLine("stringPartWithOutBuiltIn");
            //sp.stringPartWithOutBuiltIn();
            //Console.WriteLine();

            //Console.WriteLine("longestWordOfString");
            //sp.longestWordOfString();
            //Console.WriteLine();

            //Console.WriteLine("splitStringDemo");
            //sp.splitStringDemo();
            //Console.WriteLine();

            //Console.WriteLine("stringPartFromArrayOfString");
            //sp.stringPartFromArrayOfString();
            //Console.WriteLine();

            //Console.WriteLine("findAllSubstring");
            //sp.findAllSubstring();
            //Console.WriteLine();

            //Console.WriteLine("countOccuranceOfEachChar");
            //sp.countOccuranceOfEachChar();
            //Console.WriteLine();

            //Console.WriteLine("countNumberOfWordsInString");
            //sp.countNumberOfWordsInString();
            //Console.WriteLine();

           
        }
    }
}
