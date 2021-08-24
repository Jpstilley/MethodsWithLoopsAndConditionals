using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

        static void Main(string[] args)
        {
            DecreaseToNegative();
            IncreaseByThree();
            CompareTwoNumbers();
            CompareEvenOrOdd();
            IsPositiveOrNegative();
            CanVote();
            IsBetweenTenAndNegativeTen();
            MuliplesOfInput();
        }

        static int GetUserIntInput(string question)
        {
            Console.WriteLine(question);
            string reply = Console.ReadLine();
            while (reply == "" || !int.TryParse(reply, out int result))
            {
                Console.WriteLine($"\nCome on now. \nQuit messing around " +
                                  $"and give us a proper response!");
                reply = Console.ReadLine();
            }
            return int.Parse(reply);
        }

        public static void DecreaseToNegative()
        {
            Console.WriteLine("Gonna be a lot of numbers decreasing now.");
            for (int num = 1000; num >= -1000; num--)
            {
                Console.WriteLine(num);
            }
        }

        public static void IncreaseByThree()
        {
            Console.WriteLine("\nNow lets increase numbers by 3");
            for (int multipleOfThree = 3; multipleOfThree <= 999; multipleOfThree += 3)
            {
                Console.WriteLine(multipleOfThree);
            }
        }

        public static void CompareTwoNumbers()
        {
            var userNum1 = GetUserIntInput("\nPlease enter a number.");
            var userNum2 = GetUserIntInput("\nPlease enter another number or the same number. Your choice.");
            Console.WriteLine($"\nNow lets see if {userNum1} and {userNum2} are equal.");
            Console.WriteLine(userNum1 == userNum2 ? "\nThese numbers are equal."
                                                   : "\nThese numbers are not equal.");
        }

        public static void CompareEvenOrOdd()
        {

            var userInput = GetUserIntInput("\nPlease enter a number.");
            Console.WriteLine((userInput % 2 == 0) ? "\nThe number you entered is even."
                                                   : "\nThe number you entered is odd.");
            
        }

        public static void IsPositiveOrNegative()
        {
            var userNum = GetUserIntInput("\nPlease enter a positive or negative number.");
            if (userNum > 0)
                Console.WriteLine("\nThe number you entered was positive");
            else
                Console.WriteLine("\nThe number you entered was negative");
        }

        public static void CanVote()
        {
            Console.WriteLine("\nLet's see if you can vote.");
            var age = GetUserIntInput("\nPlease enter your age.");
            Console.WriteLine((age >= 18) ? "\nYes, you may vote.\nPlease do so in the next elction."
                               : "\nI'm sorry, but you are not old enough to vote yet.");
        }

        public static void IsBetweenTenAndNegativeTen()
        {
            var userNum = GetUserIntInput("\nPlease enter a number and we'll see if it's between -10 and 10");
            Console.WriteLine((userNum <= 10 && userNum >= -10) ? "\nYour number is between -10 and 10"
                                                     : "\nYour number is not between -10 and 10");
        }

        public static void MuliplesOfInput()
        {
            Console.WriteLine();
            var userInput = GetUserIntInput("\nPlease enter a number we will show all the multiples of that number through 12.\n");
            for (int multiplier = 1; multiplier < 13; multiplier++)
            {
                Console.WriteLine($"{userInput} x {multiplier} = {userInput * multiplier}");
            }
        }
    }
}
