using System;
using System.Reflection.Metadata.Ecma335;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        //Validating the Integer BKAug2620
        static int ValidateInteger(string question)
        {
            int number = 0;
            string str = "";
            while (!int.TryParse(str, out number))
            {
                Console.WriteLine(question);
                str = Console.ReadLine();
            }
            return number;
        }

        static string ValidateString(string question)
        {
            string str = "";
            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("This can't be blank " + question);
                str = Console.ReadLine();
            }

            return str;
        }


        static Array GetTwoNumbers()
        {
            var numberOne = ValidateInteger("Enter a Valid number......");
            var numberTwo = ValidateInteger("Enter a Valid number......");

            int[] twoNumbers = { numberOne, numberTwo };

            return twoNumbers;
        }

        //Write a method that will print to the console all numbers 1000 through -1000.
        static void PrintingAllNumbers()
       {
            
            for (int i = 1000;  i <= -1000;  i--)
            {
                Console.WriteLine(i);
            }
        
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        static void PrintNumbersOutByThree()
        {
            for (int i = 3; i < 999; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        static string AreNumbersEqual(int num1, int num2)
        {
            return (num1 == num2) ? "Equal" : "Not Equal";
        }

        //Write a method to check whether a given number is even or odd.
        static string  isNumberOdd(int isNumOdd)
        {
            return (isNumOdd % 2 == 0) ? "Even" : "Odd";
        }

        //Write a method to check whether a given number is positive or negative.
        static string isPostiveNumber(int isPostiveNum)
        {
             return (isPostiveNum >= 1) ? "Postive Number" : "Negative Number";
        }

        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
       static string AreYouOld(int age)
        {

            return (age > 18) ? "You are over 18" : "You are under 18";
        }

        static string CanYouVote(int voterAge)
        {
            return (voterAge >= 18) ? "You Can vote." : $"I'm sorry but you can't vote right now. You can vote in {18 - voterAge} years.";
        }


        static void Main(string[] args)
        {
            int number = ValidateInteger("Enter a Valid number......");
            //int numberTwo = ValidateInteger("Enter a Valid number......");

            //Write a method that will print to the console all numbers 1000 through -1000.
            //PrintingAllNumbers();

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            //PrintNumbersOutByThree();

            //Write a method to accept two integers as parameters and check whether they are equal or not.
            //Console.WriteLine( AreNumbersEqual(number, numberTwo) ); 

            //Write a method to check whether a given number is even or odd.
            //Console.WriteLine(isNumberOdd(number));

            //Write a method to check whether a given number is positive or negative.
            //Console.WriteLine(isPostiveNumber(number));

            //
            Console.WriteLine(CanYouVote(number));

        }
    }


}
