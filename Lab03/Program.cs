using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool validNumber = false;
            string userName= " ";
            bool loopAgain = true;

            Console.Write("Hi, what is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet your {userName}!");

            do
            {
                do
                {
                    do
                    {
                        Console.Write($"\n{userName} please enter a number between 1 and 100: ");
                        validNumber = int.TryParse(Console.ReadLine(), out number);  //check that an integer was entered

                        if (validNumber == false)  //Give the user a note that it wasn't an integer
                        {
                            Console.WriteLine($"Sorry {userName} that doesn't seem like a valid number, try it again.");
                        }
                        if (validNumber == true && number < 1 || number > 100) //check the number is in range
                        {
                            Console.WriteLine($"Sorry {userName} that number isn't between 1 and 100.");
                        }
                    } while (validNumber == false);

                } while (number < 1 || number > 100);  //loop until a valid integer between 1 and 100 is entered

                if (number%2 != 0)
                {
                    Console.WriteLine($"{number} and odd");
                }else if (number%2 == 0 && number<26)
                {
                    Console.WriteLine($"Even and less than 25");
                } else if (number%2 == 0 && number > 25 && number <= 60)
                {
                    Console.WriteLine("Even");
                } else if (number%2 == 0 && number>60)
                {
                    Console.WriteLine($"{number} and even");
                }

                bool realYesNoAnswer = false;

                do
                {
                    Console.Write($"Would you like to continue {userName}? (y/n): ");
                    var ynContinue = Console.ReadLine();

                    if (ynContinue.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        loopAgain = true;
                        realYesNoAnswer = true;
                    }
                    else if (ynContinue.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        loopAgain = false;
                        realYesNoAnswer = true;
                    }
                    else
                    {
                        Console.WriteLine("That isn't a yes or no answer, type y for yes and n for no.");
                    }
                } while (realYesNoAnswer == false);

            } while (loopAgain == true);




        }
    }
}
