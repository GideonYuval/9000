using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9000
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //1
        // param: positive number
        // return: sum of all numbers from 1 to n
        // n = 5 return 15 (1+2+3+4+5)
        public static int sum(int n)
        {
            return 0;
        }
        //2
        // param: positive number
        // return: n! (factorial n)
        // n = 4 return 24 (1*2*3*4)
        public static int factorial(int n)
        {
            return 0;

        }
        //3
        // param: positive number
        // return: num of digits
        // n = 2981 return 4
        public static int numOfDigits(int n)
        {
            return 0;

        }

        //4
        // param: positive number
        // return: sum of digits over and over until sum is one digit
        // 991 -> 19 -> 10 -> 1
        // TIP:
        // first write sumOfDigitsHelp. see the issue you get when calling with, for example, 94
        // then write sumOfDigits that calls sumOfDigitsHelp to fix this
        public static int sumOfDigits(int n)
        {
            return 0;

        }
        
        //start by writing this
        public static int sumOfDigitsHelp(int n)
        {
            return 0;

        }
        //5
        // param: double positive number
        // return: fractional part
        // 991.123 -> 0.123
        // use only +/-
        // tip: think like a little kid...
        public static double fractionalPart(double num)
        {
            return 0;


        }
        //6
        // param: positive number
        // return: product of odd numbers from 1 to n
        // n = 5 return 15 (1*3*5)
        // n = 6 return 15 (1*3*5)
        // tip: write oddsProductHelp for odd numbers, then add a wrapper (oddsProduct) to handle even numbers
        public static int oddsProduct(int n)
        {
            return 0;

        }
        public static int oddsProductHelp(int n)
        {
            return 0;

        }

        //8
        // param: positive number
        // return: biggest Difference Between Two AdjacentDigits
        // n = 291655 return 8 (9-1 > 9-2,6-1,6-5,5-5)
        public static int biggestDiff(int num) //another solution for the above
        {
            return 0;

        }

    }
}
