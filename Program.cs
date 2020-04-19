using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Loops_Handin
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue;
            int maxValue;
            int response;
            bool correct = true;
            Random rand1 = new Random();

            int testScore;
            int totalScores = 0;
            string finish;
            string root = "done";
            int numberScores = 0;
            double percentage = 0;
            bool done = false;

            int oddSum;
            int sumOdd = 0;

            int minValue2 = 0;
            int maxValue2 = 0;
            bool done2 = false;
            bool min = false;
            bool max = false;
            bool minMaxError = false;

            //Prompter
            Console.WriteLine("Enter a Minimum Value.");
            while (!Int32.TryParse(Console.ReadLine(), out minValue))
            {
                Console.WriteLine("Error: Enter Correct Type");
            }
            Console.WriteLine("Enter a Maximum Value.");
            while (!Int32.TryParse(Console.ReadLine(), out maxValue))
            {
                Console.WriteLine("Error: Enter Correct Type");

            }
            while (maxValue <= minValue)
            {
                Console.WriteLine("Error: min cannot be greater than max. Try again.");
                Console.WriteLine("Enter a Minimum Value.");
                while (!Int32.TryParse(Console.ReadLine(), out minValue))
                {
                    Console.WriteLine("Error: Enter Correct Type");
                }
                Console.WriteLine("Enter a Maximum Value.");
                while (!Int32.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.WriteLine("Error: Enter Correct Type");
                }
            }
            Console.Write($"Enter a number between {minValue} and {maxValue}:");

            while (correct == true)
            {
                if (Int32.TryParse(Console.ReadLine(), out response))
                {
                    if (minValue <= response && maxValue >= response)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your number is between the range you created");
                        correct = false;
                    }
                    else
                    {
                        Console.WriteLine("Your number is NOT between the range you created. Try again.");
                        Console.WriteLine("");
                        Console.Write($"Enter a number between {minValue} and {maxValue}:");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Enter the correct data type");
                    Console.WriteLine("");
                    Console.Write($"Enter a number between {minValue} and {maxValue}:");
                }
            }
            Console.WriteLine("");

            //Percent Passing
            Console.WriteLine("Enter your test scores. Enter 'done' to finish entering test scores.");
            while(done == false)
            {
                finish = Console.ReadLine();
                bool check = Int32.TryParse(finish , out testScore);
                if (check == true)
                {
                    if (testScore >= 70 && testScore <= 100)
                    {
                        numberScores = numberScores + 100;
                        totalScores++;
                    }
                    else if (testScore > 100 || testScore < 0)
                        Console.WriteLine("Error: Enter a integer between 0 and 100");
                    else
                    {
                        totalScores++;
                    }
                }
                else
                    if (finish.Equals(root, StringComparison.OrdinalIgnoreCase))
                {
                    percentage = (numberScores / totalScores);
                    Console.WriteLine($"You passed {percentage}% of your test");
                    done = true;
                }
                    else
                        Console.WriteLine("Error: Enter Integer.");    
            }
            //OddSum
            Console.WriteLine("Enter an integer. This program will print the sum of odd values from 1 to the entered number.");
            while (!Int32.TryParse(Console.ReadLine(), out oddSum))
            {
                Console.WriteLine("Error: Enter correct data type");
            }
            for (int i = 1; i <= (oddSum + 1); i = i + 2)
                sumOdd = sumOdd + i;
            Console.WriteLine($"The sum of odd integers between 1 and {oddSum} is {sumOdd}");
            Console.WriteLine("");


            //Random Numbers
            Console.WriteLine("Enter Values to recieve 25 values between your chosen range.");
            while (minMaxError == false)
            {
                min = false;
                max = false;
                while (!min)
                {
                    Console.WriteLine("Enter a minimum value.");
                    if (!Int32.TryParse(Console.ReadLine(), out minValue2))
                        Console.WriteLine("Error: Enter an Integer");
                    else
                        min = true;
                }
                while (!max)
                {
                    Console.WriteLine("Enter a maximum value.");
                    if (!Int32.TryParse(Console.ReadLine(), out maxValue2))
                        Console.WriteLine("Error: Enter an Integer");
                    else
                        max = true;
                }
                if (maxValue2 >= minValue2)
                    minMaxError = true;
                else
                    Console.WriteLine("Error: min cannot be greater than max");
            }
            Console.WriteLine("");
            for (int i = 0; i <= 25; i++)        
                Console.WriteLine(rand1.Next(minValue2, maxValue2+1));
            Console.ReadLine();
        }
    }
}
