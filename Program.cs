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
            int randNum;
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

            int minValue2;
            int maxValue2;
            bool done2 = false;
            bool min = false;
            bool max = false;

            //Console.WriteLine("Enter a Minimum Value.");
            //while (!Int32.TryParse(Console.ReadLine(), out minValue))
            //{
            //    Console.WriteLine("Error: Enter Correct Type");
            //}
            //Console.WriteLine("Enter a Maximum Value.");
            //while (!Int32.TryParse(Console.ReadLine(), out maxValue))
            //{
            //    Console.WriteLine("Error: Enter Correct Type");

            //}
            //while (maxValue <= minValue) { 
            //    Console.WriteLine("Error: min cannot be greater than max. Try again.");
            //    Console.WriteLine("Enter a Minimum Value.");
            //    while (!Int32.TryParse(Console.ReadLine(), out minValue))
            //    {
            //        Console.WriteLine("Error: Enter Correct Type");
            //    }
            //    Console.WriteLine("Enter a Maximum Value.");
            //    while (!Int32.TryParse(Console.ReadLine(), out maxValue))
            //    {
            //        Console.WriteLine("Error: Enter Correct Type");
            //    }
            //}
            //Console.Write($"Enter a number between {minValue} and {maxValue}:");

            //while (correct == true)
            //{
            //    if (Int32.TryParse(Console.ReadLine(), out response))
            //    {
            //        if (minValue <= response && maxValue >= response)
            //        {
            //            Console.WriteLine("");
            //            Console.WriteLine("Your number is between the range you created");
            //            correct = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your number is NOT between the range you created. Try again.");
            //            Console.WriteLine("");
            //            Console.Write($"Enter a number between {minValue} and {maxValue}:");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Enter the correct data type");
            //        Console.WriteLine("");
            //        Console.Write($"Enter a number between {minValue} and {maxValue}:");
            //    }
            //}
            //for (int i = 1; i <= 5; i++)
            //    Console.WriteLine("");

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

            //Odd Sum
            Console.WriteLine("Enter Values to produce a randum number and the sum of all odd numbers to your number.");
            while(minMaxError)
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







            Console.ReadLine();
        }
    }
}
