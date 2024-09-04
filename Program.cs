// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program

{

    static void Main()

    {

        int age = 10; // Example age; this could be replaced with dynamic input in a different context

        string result = CheckVoteEligibility(age);

        Console.WriteLine(result);

        static string CheckVoteEligibility(int age)

        {

            if (age >= 18)

            {

                return "You are eligible to vote!";

            }

            else

            {

                return "You are not eligible to vote yet.";

            }

        }

    }
}



