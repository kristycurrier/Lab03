using System;
using System.Text.RegularExpressions;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // James -  Consider declaring all of these variables closer
            // to where they are going to be used. 
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
                    // James - for this loop, you could put it all in it's own method and have it return an integer.
                    Console.Write($"\n{userName} please enter a number between 1 and 100: ");

                    var numberString = Console.ReadLine();

                    // James - instead of naming this variable regex and leaving a comment for what it does, why not name
                    // the variable something close to what it does? for example
                    // var oneToOneHundredRegex = @"^(?:100|[1-9][0-9]?)$";
                    // and as I explained before, if you want regex to be as effecient as possible, you can always
                    // use a longer regex.  but honestly this is fine. 
                    var regex = @"^(?:100|[1-9][0-9]?)$"; // regular number expression for 1-100

                    // James - good short circuiting.
                    if (Regex.IsMatch(numberString, regex) && int.TryParse(numberString, out number)) //check Regex match true and output a number
                    {
                        validNumber = true;
                    }

                    // James - of using two if statments here, you could always use one if statement and print the message if it is false inside
                    // of the if statment and used "continue" to continue the loop and outside of the if statement you can "break".
                    if (validNumber == false)
                    {
                        Console.WriteLine($"Sorry {userName}, that is not a valid entry.");
                    }
                } while (validNumber == false);

                // James - For several conditions, I would maybe consider looking at a switch case statement, more of a stylistic 
                // opinion but it makes it easier to read several statements at once. 
                // Also, you can put your entire business logic in a seperate method.
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

                // James - for this entire "if you want to continue" the program, I would just put it in a seperate method. 
                do
                {
                    // James - I would name this out completely, after a couple seconds it's clear that this is used to check 
                    // if the user inputs y or n, and i also like that yo you are using regex here.  you could honestly just do this
                    // in one regex, checking for y|Y|n|N, then check if the input matches this, then make a decision after that.
                    var regexY = @"^(y|Y)$";
                    var regexN = @"^(n|N)$";
                    validNumber = false;

                    Console.Write($"Would you like to continue {userName}? (y/n): ");

                    // James - why not yesNoContinue? or userInputYesOrNoContinue, I used to think abbreviates were good, like they are clear what they are doing,  
                    // then I started reading code bases with one million plus lines of code lol. it really isn't a bad thing to make your 
                    // variable names as specific as possible
                    var ynContinue = Console.ReadLine();

                    // James - kind of touched on this earlier, but you could do this in two if statements if you want to check for yes or no inputs
                    // just have your regex match for both, and if it does not match, then you have them enter again, after they enter correctly, then
                    // you can make a decision based on yes or no.
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

                // James - conditional statements default to checking to true, just a stylistic tip, you can put 
                // 
                // while (loopAgain)
                // instead of seeing if it == true.
            } while (loopAgain == true);


            // James - I would try to clear the white space here.  overall good job, you can totally make this app like 3 or 4 seperate methods
            // but still good.

        }
    }
}
