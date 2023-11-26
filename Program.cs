using System;
using System.Linq.Expressions;

namespace Program
{
    class Student
    {


        static string CheckDecimal(string userInput)
        {

            int decimalIndex = userInput.IndexOf('.');

            // since IndexOf already returns -1 if '.'
            // is not found, there's no need to use
            // numberString.Contains(".")
            bool isDecimal = decimalIndex >= 0;

            if (isDecimal)
            {
                // Take two decimal digits by shifting
                // the index of '.' by 2 positions to the right
                var decimalDigitsIndex = decimalIndex + 2;

                // Truncate the number to 2 decimal digits
                var truncatedNumber = userInput.Substring(0, decimalDigitsIndex);

                return truncatedNumber;
            }
            else if (isDecimal == false)
            {
                return "False";
            }
            return "Error";
        }


        public static void Main(string[] args)
        {
            try
            {
                string mark;

                Console.Write("Enter your mark here : ");

                mark = Console.ReadLine()!;

                bool mark2 = double.TryParse(mark, out double result);

                //Console.WriteLine(mark2);

                int number = GetZero();

                bool number2 = result >= 0;

                double result3 = result;

                while ((mark2 == false) || (number2 == false) || (result > 20) || (result < 0))
                {
                    int i = 0;
                    i++;
                    Console.Write("the answer have to be a positive number and greater or equal to 0 and lower or equal to 20 : ");

                    mark = Console.ReadLine()!;

                    bool mark3 = double.TryParse(mark, out double result2);

                    bool number3 = result2 >= 0;

                    bool number4 = result2 >= 0;

                    bool number5 = result2 <= 20;

                    decimal temp2 = Convert.ToDecimal(result2);

                    if (mark3 == true && number3 == true && number4 && number5)
                    {
                        result3 = result2;
                        break;
                    }
                    else if (i == 5)
                    {
                        Console.Write("number of tries exceeded");
                        Environment.Exit(0);
                    }
                    else
                    {
                        continue;
                    }
                }

                string temp = Convert.ToString(result3);

                var variable = CheckDecimal(temp);
                Console.WriteLine($"\n\n\n\n\n{variable}\n\n\n\n\n");
                if (variable != "Error" && variable != "False")
                {
                    Console.WriteLine("number is valid");
                    result3 = Convert.ToDouble(temp);
                }
                else if (variable == "False")
                {
                    result3 = Convert.ToDouble(result);
                }
                else
                {
                    Console.WriteLine("Number isn't valid, restart the program");
                    Environment.Exit(0);
                }

                /*if (variable == "Error")
                {
                    Console.WriteLine("An error occured, restart the program and try again");
                    Environment.Exit(0);
                }
                else
                {
                    result3 = Convert.ToDouble(variable);
                }*/

                Console.WriteLine("Your test mark is " + result3);

                switch (result3)
                {
                    case double n when n == 0 || n < 5:

                        Console.WriteLine("You've failed");

                        break;

                    case double n when n >= 5 && n < 10:

                        Console.WriteLine("You're going to have a second chance");

                        break;

                    case double n when n >= 10 && n <= 20:

                        Console.WriteLine("You've passed");

                        break;

                    default:

                        Console.WriteLine("Close the program and try again");

                        Environment.Exit(0);

                        break;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private static int GetZero()
        {
            return 0;
        }
    }
}