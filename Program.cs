using System;

namespace Bonus_1
{
    class Program
    {
        
        public static string reading()
        {
            //This method prompt the user to input a list of integer in type of string. //Also validate if the input is valid and return the string
            //If input is not valid, keep asking user to enter valid input
            int doing = 1;
            string input;
            int size;
            int falsecount = 0;
            do
            {
                Console.WriteLine("Input: ");
                input = Console.ReadLine();
                string[] numbers = input.Split(','); //Spliting input by comma into arrays of string
                size = numbers.Length;
                falsecount = 0; //falsecount use for valiadation, if string is valid ==> falsecount is 0. If not, falsecount >= 1
                foreach (var number in numbers)
                {
                    int length = number.Length; //obtaining the length of single input (single number)

                    if (number == "") //Checking if any empty number
                    {
                        Console.WriteLine("Invalid. Try again. List of integers SEPERATED by ONLY COMMAS");
                        falsecount++;
                        break;
                    }
                    if (falsecount > 0)
                    {
                        break;
                    }
                    for (int i = 0; i < length; i++)
                    {
                        int checknumber = number[i];
                        if (i == 0)
                        { 
                            //The first character of number could have the sign + or  - and numbers from 0 to 9
                            //If the first character is not in any situation above it will shows ERROR MASSAGE
                            if (!(checknumber == 43 || checknumber == 45 || (checknumber >= 48 && checknumber <= 57)))
                            {
                                Console.WriteLine("Invalid. Try again. List of integers SEPERATED by ONLY COMMAS");
                                falsecount++;
                                break;
                            }
                        }
                        else
                        {
                            //Others remaning characters are just numbers from 0 to 9 
                            if (!(checknumber >= 48 && checknumber <= 57))
                            {
                                Console.WriteLine("Invalid. Try again. List of integers SEPERATED by ONLY COMMAS");
                                falsecount++;
                                break;
                            }
                        }
                    }
                }
                /// Terminate the loop if the string is valid because falsecount is 0
                if (falsecount == 0)
                {
                    doing = 0;

                }
                ///If the size is 0, or input is "" it continues to the LOOP
                if (input == "" || size == 0)
                {
                    doing = 1;
                }
            }
            while (doing == 1);
        return input;
        }

        public static void SumAndAverage (string input)
        {
            //This method take a string of integers with comma, turn it to arrays of integers and calculate sum and average
            string[] numbers = input.Split(',');
            int size = numbers.Length;
            int[] integers = new int[size];
            int sum = 0;
            double average = 0;
            for (int i = 0; i < size; i++)
            {
                integers[i] = Convert.ToInt32(numbers[i]);
                sum += integers[i];

            }
            average = Convert.ToDouble(sum) / size;
            Console.WriteLine($"Sum: {sum} || Average: {average}");
        }
        
        static void Main(string[] args)
        {
            do
            {
                string IntegersList = reading();

                SumAndAverage(IntegersList);

                Console.WriteLine("Press 0 To EXIT. PRESS ANY KEYS to CONTINUE");
                string exit = Console.ReadLine();
                if (string.Compare(exit,"0") == 0)
                {
                    break;
                }

            }
            while (true);

        }
    }
}
