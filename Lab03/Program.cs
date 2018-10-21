using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool validNumber = false;
            string userName = "";
            bool loopAgain = true;


            Console.Write("Hi, what is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet your {userName}!");

            do
            {

                do
                {
                    Console.Write($"\n{userName} please enter a number between 1 and 100: ");

                    var numberString = Console.ReadLine();
                    var regex = @"^(?:100|[1-9][0-9]?)$"; // regular number expression for 1-100

                    if (Regex.IsMatch(numberString, regex) && int.TryParse(numberString, out number)) //check Regex match true and output a number
                    {
                        validNumber = true;
                    }

                    if (validNumber == false)
                    {
                        Console.WriteLine($"Sorry {userName}, that is not a valid entry.");
                    }
                } while (validNumber == false);

                if (number % 2 != 0)
                {
                    Console.WriteLine($"{number} and odd");
                }
                else if (number % 2 == 0 && number < 26)
                {
                    Console.WriteLine($"Even and less than 25");
                }
                else if (number % 2 == 0 && number > 25 && number <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"{number} and even");
                }

                bool realYesNoAnswer = false;

                do
                {
                    var regexY = @"^(y|Y)$";
                    var regexN = @"^(n|N)$";
                    validNumber = false;

                    Console.Write($"Would you like to continue {userName}? (y/n): ");

                    var ynContinue = Console.ReadLine();

                    if (Regex.IsMatch(ynContinue, regexY))
                    {
                        loopAgain = true;
                        realYesNoAnswer = true;
                    }
                    else if (Regex.IsMatch(ynContinue, regexN))
                    {
                        Console.WriteLine("Bye!");
                        Console.ReadKey();
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
