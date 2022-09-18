using System;
using System.ComponentModel.DataAnnotations;
using MethodsWithLoopsAndConditionals;

namespace MethodsExercise
{
    class Program
    {
        static void Main()
        {
            //print all numbers decreasing from 1000 to -1000
            Methods.Print1000toNeg1000();

            //print multiples of 3 up to 999
            Methods.CountByThrees();

            //Enter two integers and check if they are equal
            Console.WriteLine("Enter two integers: ");
            var input1 = int.Parse(Console.ReadLine());
            var input2 = int.Parse(Console.ReadLine());

            var output = (Methods.IsEqual(input1, input2)) ? "These numbers are equal" : "These numbers are not equal";
            Console.WriteLine(output);

            //1. Checks if input number is even or odd
            //2. Checks if input number is positive or negative
            Console.WriteLine("Enter one integer: ");
            input1 = int.Parse(Console.ReadLine());

            output = (Methods.EvenOrOdd(input1) == 0) ? "This number is éven" : "This number is odd";
            Console.WriteLine(output);

            
            if (Methods.PositiveOrNegative(input1) == 1)
            {
                output = "This number is positive";
            }
            else if (Methods.PositiveOrNegative(input1) == -1) 
            {
                output = "This number is negative";
            }
            else 
            {
                output = "This number is 0 thus neither positive or negative";
            }
            Console.WriteLine(output);

            //Check if user is old enough to vote
            Console.Write("Enter your age: ");
            input1 = int.Parse(Console.ReadLine());

            output = (Methods.CanVote(input1)) ? "You can vote!" : "You are not old enough to vote yet";
            Console.WriteLine(output);


            //Check if user input is within range
            Console.WriteLine("Enter an integer between -10 and 10: ");
            input1 = int.Parse(Console.ReadLine());
            
            if (Methods.IsInRange(input1))
            {
                Console.WriteLine("In range");
            }
            else
            {
                Console.WriteLine("Error: Not in range");
            }

            //Print out multiplication table for user input
            Console.WriteLine("Enter an integer: ");
            input1 = int.Parse(Console.ReadLine());
            Methods.MultiplicationTables(input1);
        }
    }
}