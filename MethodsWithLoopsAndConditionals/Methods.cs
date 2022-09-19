using System;
namespace MethodsWithLoopsAndConditionals
{
    public class Methods

    //LukeWarm Section

    //Use as many descriptive names as possible. I do not want to see myInt1 - 100!
    //For training purposes, most if not all the data for these methods can come from user input.
    //Each one of these methods should be called from Main() and declared in the Program class.
    //Be as creative as you want, the goal is to have working methods but if you want to make them look nice, go for it. As in Num 6 w/ age and voting method, you can say “You may vote” or “Looks like you're too young this time!” based on their age.
    //This project should work in a manner where if someone forks/clones this from GitHub, they can just press the play button and have every method run in sequence, so all interface dialogue should be in place already. When finished, push this to GitHub!

    //LukeWarm Section:
    //Write a method that will print to the console all numbers 1000 through -1000
    //Write a method that will print to the console numbers 3 through 999 by 3 each time
    //Write a method to accept two integers as parameterss and check whether they are equal or not
    //Write a method to check whether a given number is even or odd
    //Write a method to check whether a given number is positive or negative
    //Write a method to read the age of a candidate and determine whether they can vote.
    //Hint: Use Parse or the safer TryParse() for an extra challenge

    //Heatin Up Section:
    //Write a method to check if an integer (from the user) is in the range -10 to 10
    //Write a method to display the multiplication table (from 1 to 12) of a given integer

    {
        public static object ConvertToInt { get; private set; }

        public static void LukeWarm1()
        {
            for (int num = 1000; num >= 1000 && num <= 1000; num--)
            {
                Console.WriteLine(num);
            }
        }

        public static void LukeWarm2()
        {
            int newNumber = 0;
            while (newNumber <= 999)
            {
                Console.WriteLine(newNumber);
                newNumber += 3;
            }
        }

        public static void LukeWarmEquality()

        {
            Console.WriteLine("Input your first integer:");
            int userInput1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input your second integer:");
            int userInput2 = int.Parse(Console.ReadLine());

            string equalityAnswer = (userInput1 == userInput2) ? "These values are equal." : "These values are NOT EQUAL.";
            Console.WriteLine(equalityAnswer);
        }


        public static void EvenOrOdd(double someNumber)
        {
            while (true)
            {
                string evenOrOdd = (someNumber % 2.0 == 0.0) ? $"{someNumber} is even" : $"{someNumber} is  odd.";
                Console.WriteLine(evenOrOdd);
                break;
            }
        }

        public static void PosORNeg()
        {
            Console.WriteLine("Input an integer to find out whether it is positive or negative.:");
            int? inputPosNeg = int.Parse(Console.ReadLine());

            if (inputPosNeg > 0)
            {
                Console.WriteLine("This number is positive.");
            }
            else if (inputPosNeg < 0)
            {
                Console.WriteLine("This number is negative.");
            }
            else
                Console.WriteLine("Your input was either 0 or invalid.");

        }

        public static void VotingAge()
        {
            Console.WriteLine("Input voter candidate age here:");
            int? candidateAge = int.Parse(Console.ReadLine());

            if (candidateAge < 18)
            {
                Console.WriteLine("We appreciate your desire to make a difference. However, you have been deemed too young to participate in this election. Try again when you are 18.");
            }
            else if (candidateAge >= 18)
            {
                Console.WriteLine("You are a prime voting candidate! Your vote will surely make a difference!");
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
            Console.ReadLine();
        }


        //Heatin Up
        public static void Range()
        {
            Console.WriteLine("Enter a number to see if it's within range: ");
            int trialNum = ConvertToInt.(Console.ReadLine());
            if (trialNum <= 10 && trialNum >= 10)
            {
                Console.WriteLine($"{trialNum} is WITHIN range");
            }
            else
            {
                Console.WriteLine($"{trialNum} is NOT in range.");
            }

        }


        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {1} = (number * i)");
            }
        }
    }
}
