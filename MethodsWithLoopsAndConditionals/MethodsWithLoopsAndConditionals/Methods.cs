using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals;

internal class Methods
{


    public static void Print1000toNeg1000()
    {
        for (int i = 1000; i > -1000; i--)
        {
            Console.Write($"{i} ");

            if (i % 20 == 0) Console.WriteLine("\n");
        }
    }

    public static void CountByThrees()
    {
        for (int i = 3; i <= 999; i+= 3)
        {
            Console.Write($"{i} ");

            if (i % 20 == 0) Console.WriteLine("\n");
        }
    }

    public static bool IsEqual(int num1, int num2)
    {
        if (num1 == num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //returns 0 for even;
    //returns 1 for odd
    public static int EvenOrOdd(int num)
    {
        return num % 2;
    }

    //returns 1 for Positive
    //returns -1 for Negative
    //returns 0 for 0
    public static int PositiveOrNegative(int num)
    {
        if (num > 0) 
        {
            return 1;
        }
        else if (num < 0) 
        {
            return -1;

        }
        else 
        {
            return 0;
        }
    }

    public static bool CanVote(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool IsInRange(int userInput)
    {
        if (userInput >= -10 && userInput <= 10) 
        { 
            return true; 
        }
        else return false;
    }

    public static void MultiplicationTables(int num)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
