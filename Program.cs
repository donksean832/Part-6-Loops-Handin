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
            int testScore;
            int totalScores = 0;
            bool correct = true;
            bool done = false;
            int numberScores = 0;
            double percentage = 0;
            Random rand1 = new Random();

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
            while (maxValue <= minValue) { 
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
            for (int i = 1; i <= 5; i++)
                Console.WriteLine("");

            //Percent Passing
            Console.WriteLine("Enter Your Test Scores. Type 1 to stop");
            while(done == false)
            {
                if (Int32.TryParse(Console.ReadLine(), out testScore) && testScore != 1)
                {
                    if (testScore >= 70 && testScore <= 100)
                        numberScores++;
                    else if (testScore == 1)
                    {
                        percentage = ((numberScores / totalScores) * 100);
                        Console.WriteLine("You passed");

                    }

                    else if (testScore > 100 || testScore < 0)
                        Console.WriteLine("Error: Enter a integer between 0 and 100");
                    else
                        totalScores++;


                }
                else
                    Console.WriteLine("Error: Enter an integer between 0 and 100");
            }

            


            Console.ReadLine();


        }
    }
}
