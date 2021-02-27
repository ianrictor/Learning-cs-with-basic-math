using System;              //default cleaned the code in VS, eliminating unused namespaces, leaving only System

namespace Learning_cs_with_basic_math   //a lil program with that delves into new things. I'm thinking about adding my number sorter to the menu using arrays to
                                        //give sort of a tour de force of the basic stuff I've learned so far!
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Ian's Magical Maths Machine\n"); //leave the title out of the do while loop to make it appear once, \n skips a line
            do
            {
                Console.WriteLine("Choose a calculation function:");
                Console.WriteLine("1. Add two numbers.");
                Console.WriteLine("2. Subtract two numbers.");
                Console.WriteLine("3. Multiply two numbers.");
                Console.WriteLine("4. Divide two numbers.");
                Console.WriteLine("5. Check the equality of two numbers.");
                Console.WriteLine("6. Display the sum of the first ten natural numbers.");
                Console.WriteLine("7. Exit Program.");

                string menuChoice = Convert.ToString(Console.ReadLine());

                switch (menuChoice)
                {
                    case "1":                       //quotes for string cases
                        Addition(0, 0);             //initialize values to 0
                        break;
                    case "2":
                        Subtraction(0, 0);
                        break;
                    case "3":
                        Multiplication(0, 0);
                        break;
                    case "4":
                        Division(0, 0);
                        break;
                    case "5":
                        checkEquality(0, 0);
                        break;
                    case "6":
                        sumFirstTenNumbers(0, 0);
                        break;
                    case "7":
                        Environment.Exit(0);    //exits console application environment
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option."); //accounts for bad user intput. 
                        break;                                              //Using string rather than int for menu choice allows for much more input to direct to default!
                }
            }
            while (true);   //automatically loops the menu after each case
        }

        static void Addition(int num1, int num2)
        {
            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());         //Convert.ToInt32 makes sure any input becomes an int for the function
            Console.WriteLine("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum is {0}.", sum);
        }

        static void Subtraction(int num1, int num2)
        {
            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int difference = num1 - num2;
            Console.WriteLine("The difference is {0}.", difference);
        }

        static void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * num2;
            Console.WriteLine("The product is {0}.", product);
        }

        static void Division(decimal num1, decimal num2)
        {
            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            decimal quotient = num1 / num2;                         //use decimal, float, or double to allow for non-integer quotients from two int. Ie. 7/4 etc.
            Console.WriteLine("The quotient is {0}.", quotient);
        }

        static void checkEquality(int num1, int num2)
        {
            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal.", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal.", num1, num2);
            }
        }
        static void sumFirstTenNumbers(int i, int sum)
        {
            for (i = 1; i <= 10; i++)   //start at 1, for all numbers less that or equal to 10, ascend integers (hardcoded for first ten integers)
            {
                sum = sum + i;          //add up ascending integers
            }
            Console.WriteLine("The sum of 1 through 10 is {0}.", sum);
        }
    }
}
