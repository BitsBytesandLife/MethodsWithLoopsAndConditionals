using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

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
        static string CanYouVote(int voterAge)
        {
            return (voterAge >= 18) ? "You Can vote." : $"I'm sorry but you can't vote right now. You can register to vote in {18 - voterAge} years.";
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10.
        static string isNumberInRange(int numberCheck) 
        {
            return (numberCheck >= -10 && numberCheck <= 10) ? "Number is in range" : "Number is not in Range";
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        static string MultiplicationTable(int number) 
        {
            var xTable = "Number is not in the range";

            if (number >= 1 && number <= 12)
            {
                xTable = "";
                for (int i = 1; i <= 12; i++)
                {
                    xTable = $"{number} x {i} = {number * i} \n" + xTable;
                }
            }

            return xTable;        }


        //Write a method that takes a number from the user and returns an array with that many indexes.The values shall be random numbers.
        static Array RandomArr(int number) 
        {
            List<int> arr = new List<int>();
            Random r = new Random();

            for (int i = 0; i < number; i++)
            {
                arr.Add(r.Next(1,500));
            }

            return arr.ToArray();
        }

        static void ShowArray(Array randomList)
        {
            foreach (var item in randomList)
            {
                Console.WriteLine(item);
            }

        }

        //Write a method to compute the sum of all the elements in an array of integers.
        static int SumOfAnArray(Array sumOfAnArray)
        {
            var sum = 0;
            //can't use var here I have to be explict?
            foreach (int item in sumOfAnArray)
            {
                sum += item;
            }

            return sum;
        }

        //Write a method to display the cube of the number up to given an integer.    
        //(If a user inputs the number 3 the method should print to the console: 
        //Number is: 1 and the cube of 1 is:1, Number is: 2 and the cube of 2 is: 8, 
        //Number is: 3 and the cube of 3 is:27)
        static void CubeOfANumber(int number)
        {
            Console.WriteLine($"{number * number * number}");
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

            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
            //Console.WriteLine(CanYouVote(number));

            //Write a method to check if an integer(from the user) is in the range -10 to 10.
            //Console.WriteLine(isNumberInRange(number));

            //Write a method to display the multiplication table(from 1 to 12) of a given integer.
            //I need breack room for this
            //Console.WriteLine(MultiplicationTable(number));

            //Write a method that takes a number from the user and returns an array with that many indexes.The values shall be random numbers.
            //Array RandomNum = RandomArr(number);
            //Console.WriteLine("Let's show the contents of this Random Array");
            //ShowArray(RandomNum);

            //Write a method to compute the sum of all the elements in an array of integers.
            //Array sum = RandomArr(number);
            //ShowArray(sum);
            //Console.WriteLine($"{SumOfAnArray(sum)}");

            //Write a method to display the cube of the number up to given an integer.    
            //(If a user inputs the number 3 the method should print to the console: 
            //Number is: 1 and the cube of 1 is:1, Number is: 2 and the cube of 2 is: 8, 
            //Number is: 3 and the cube of 3 is:27)

            //CubeOfANumber(number);
        }
    }


}
