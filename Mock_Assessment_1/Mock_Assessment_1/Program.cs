using System;

namespace Mock_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers: ");
            var userInput = Console.ReadLine();
            int num1 = int.Parse(userInput);

            var userInput2 = Console.ReadLine();
            int num2 = int.Parse(userInput2);

            if (IsTheSame(num1,num2))
            {
                Console.WriteLine("Your program worked");
            }
            else
            {
                Console.WriteLine("Your numbers did not equal, so I'm going to do something else. TTYL.");
            }

            Console.WriteLine(Subtract(num1,num2));
            
            FindBuildingType(num1);
        }

        public static bool IsTheSame(int num1, int num2)
        {
            bool equal = num1 == num2;
            bool notEqual = !(num1 == num2);

            if (equal)
            {
                return true;
            }
            else if (!(notEqual))
            {
                return false;
            }

            return false; // ask Jason/Kristy why this has to return false instead of true
        }
        public static double Subtract(double num1, double num2)
        {
            double difference = num1 - num2;

            return difference;
        }
        public static int FindBuildingType(int num1)
        {
            if (num1 >= 4 && num1 <= 10)
            {
                Console.WriteLine("This is an office building!");
            }
            else if (num1 >= 50)
            {
                Console.WriteLine("This is a SUPER skyscraper!");
            }
            else if (num1 >= 11 && num1 <= 49)
            {
                Console.WriteLine("This is a skyscraper!");
            }
            else if (num1 <= 3 && num1 >= 0)
            {
                Console.WriteLine("This is a house!");
            }

            return num1; // ask Jason/Kristy why do negative numbers still get calculated
        }

    }
}
