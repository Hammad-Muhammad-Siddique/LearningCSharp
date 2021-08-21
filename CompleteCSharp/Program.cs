using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //_________________________________________________________________________________________
            //_________________________________________________________________________________________

            //                                  LOOPS

            //__________________________________________________________________________
            
            //                                 FOR LOOP

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;

            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //_______________________________________________________________________________

            //                               WHILE LOOP

            //Console.ReadLine();

            //int index = 1;

            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //string guess = "";
            //string secretWord = "hammad";

            //while (guess != secretWord)
            //{
            //    Console.Write("Enter guess: ");
            //    guess = Console.ReadLine();
            //}

            //Console.WriteLine("You Win!");

            //Console.Write("Enter the month number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GetMonth(number));

            //_______________________________________________________________________________

            //                                  DO-WHILE LOOP

            //do
            //{
            //    Console.Write("Enter guess: ");
            //    guess = Console.ReadLine();
            //    guessCount++;
            //}
            //while (secretWord == guess || guessCount == noOfGuesses);

            //string guess = "";
            //string secretWord = "hammad";
            //int noOfGuesses = 3;
            //int guessCount = 0;

            //______________________________________________________________________________

            ////Console.ReadLine();

            //while (guessCount != noOfGuesses)
            //{
            //    if (guess == secretWord)
            //    {
            //        Console.WriteLine("You guessed it!");
            //    }
            //    else
            //    {
            //        Console.Write("Enter Guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }



            //Console.Write("Enter the corresponding day number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GetDay(number));

            //Console.ReadKey();

            //Console.Write("Enter first number: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operator: ");
            //string op = Console.ReadLine();

            //if (op == "+")
            //{
            //    Console.WriteLine("The sum of the two numbers is " + (number1 + number2));
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine("The difference of the numbers is " + (number2 - number1));
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine("The ratio of the numbers is " + (number1 / number2));
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine("The product of the numbers is " + (number1 * number2));
            //}
            //else
            //{
            //    Console.WriteLine(" Invalid operator");
            //}

            //_________________________________________________________________________________________
            //_________________________________________________________________________________________

            //                                  STRING FUNCTIONS


            // String Functions
            // String.ToUpper() -- Converts the string into uppercase characters
            // String.ToLower() -- Converts the string into lowercase characters
            // String.Contains("Letters") -- Checks whether the string contains the letters or not
            // String[Number] --Prints out the character at the index number Number
            // String.IndexOf("Letters") OR String.IndexOf('Letter') -- Prints out the index number at which letters or letter occurs
            // String.Substring(Number) OR  String.Substring(Number1, Number2) -- Prints out the string at index number Number and the rest of the string and prints out the string at Number1 and Number2 many strings

            //Console.WriteLine(Name.ToUpper());
            //Console.WriteLine(Name.ToLower());
            //Console.WriteLine(Name.Contains("Hammad"));
            //Console.WriteLine(Name[12]);
            //Console.WriteLine(Name.IndexOf('S'));
            //Console.WriteLine(Name.IndexOf("Siddique"));
            //Console.WriteLine(Name.Substring(7, 3));

            //Console.WriteLine("My name is...\nHammad Siddique!");
            //Console.WriteLine("The number of letters in my name are " + Name.Length);

            //___________________________________________________________________________________________________________
            //__________________________________________________________________________________________

            //                                  MATH FUNCTIONS


            //Console.WriteLine(Math.Min(4,60));
            //Console.WriteLine(Math.Max(45,90));
            //Console.WriteLine(Math.Pow(2, 3));

            //Console.WriteLine(Math.Sqrt(36));
            //Console.WriteLine(Math.Round(36.7));
            //Console.WriteLine(Math.Truncate(46.89));
            //Console.WriteLine(Math.Abs(-67));


            //_______________________________________________________________________________________________
            //_____________________________________________________________________________________

            //                                  1D ARRAY

            //string[] members = new string[7];
            //members[0] = "Hammad";
            //members[1] = "Huzaifa";
            //members[2] = "Nimra Baji";
            //members[3] = "Ifra Baji";
            //members[4] = "Bhai Jaan";
            //members[5] = "Mama";
            //members[6] = "Papa";                                

            //_______________________________________________________________________________________________

            //                                  USING BOOLEANS

            //bool isMale;
            //bool isTall;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isTall && !isMale)
            //{
            //    Console.WriteLine("You are tall but not male");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a male but not tall");
            //}
            //else
            //    Console.WriteLine("you are niether male nor tall");

            //    Console.ReadKey();

            //_______________________________________________________________________________________________

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //int number1 = Convert.ToInt32("67");
            //int number2 = Convert.ToInt32("33");
            //Console.WriteLine(number1 + number2);

            //Console.Write("Enter a number: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(number1 + number2);



            //SayHi("Hammad", 18);
            //SayHi("Huzaifa", 18);
            //SayHi("Hassan", 25);



            //int powerNumber;
            //int baseNumber;

            //Console.Write("Enter the base number: ");
            //baseNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the power number: ");
            //powerNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(baseNumber + " to the power of " + powerNumber + " equals " + GetExponent(baseNumber, powerNumber));

            //Console.ReadKey();

            //__________________________________________________________________________________________
            //__________________________________________________________________________________________

            //                                  2D ARRAYS

            //int[,] numberGrid = new int[3, 4];
            //int[,] grid =
            //{
            //    {0,0},
            //    {1,1},
            //    {2,2},
            //    {3,3},
            //    {4,4},
            //    {5,5}
            //};

            //Console.WriteLine(grid[0, 0]);

            //Console.ReadKey();

            //_______________________________________________________________________________________________
            //_______________________________________________________________________________________________

            //                                  TRY & CATCH

            //try
            //{
            //    int number1;
            //    int number2;

            //    Console.Write("Enter a number: ");
            //    number1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter another number: ");
            //    number2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("The ratio of the two numbers is " + number1 / number2);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadKey();

            //____________________________________________________________________________________________________
            //__________________________________________________________________________________________

            //                                  

            //Book bookOne = new Book();
            //bookOne.title = "Harry Potter";
            //bookOne.author = "JK Rowling";
            //bookOne.pages = 400;

            //Book bookTwo = new Book();
            //bookTwo.title = "The Tale Of Two Cities";
            //bookTwo.author = "Charles Dickens";
            //bookTwo.pages = 800;

            //Console.WriteLine(bookOne.title);

            //Console.ReadLine();

            //Room roomOne = new Room(2, "red", "white", "chair, table, sofa, rack");

            //Console.WriteLine(roomOne.windows);
            //Console.WriteLine(roomOne.wallColour);
            //Console.WriteLine(roomOne.floorColour);
            //Console.WriteLine(roomOne.furniture);

            //Console.ReadKey();



            Console.ReadKey();
        }

        //___________________________________________________________________________________________________
        //___________________________________________________________________________________________
        
        //                                  FUNCTIONS/METHODS
                            

        //static int GetExponent(int baseNumber, int powerNumber)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powerNumber; i++)
        //    {
        //        result = result * baseNumber;
        //    }

        //    return result;
        //}

        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age + " years old");

        //}

        //static void SqaureCalculations(int length)
        //{
        //    Console.WriteLine("The length of the square is " + length);
        //    Console.WriteLine("The perimeter of the square is " + (4 * length));
        //    Console.WriteLine("The area of the square is " + (length * length));
        //}

        //static void CircleCalculations(int radius)
        //{
        //    Console.WriteLine("The radius of the circle is " + radius);
        //    Console.WriteLine("The circumference of the circle is " + (2 * Math.PI * radius));
        //    Console.WriteLine("The area of the circle is " + (Math.PI * radius * radius));

        //}

        //static string GetDay(int DayNumber)
        //{
        //    string dayName;

        //    switch (DayNumber)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //        break;

        //        case 1:
        //            dayName = "Monday";
        //        break;

        //        case 2:
        //            dayName = "Tuesday";
        //        break;

        //        case 3:
        //            dayName = "Wednesday";
        //        break;

        //        case 4:
        //            dayName = "Thursday";
        //        break;

        //        case 5:
        //            dayName = "Friday";
        //        break;

        //        case 6:
        //            dayName = "Saturday";
        //        break;

        //        default:
        //            dayName = "Invalid Day Number";
        //        break;
        //    }


        //    return dayName;
        //}


        //static string GetMonth(int monthNumber)
        //{
        //    string month;

        //    switch (monthNumber)
        //    {
        //        case 1:
        //        month = "January";
        //        break;

        //        case 2:
        //            month = "Feburary";
        //        break;

        //        case 3:
        //            month = "March";
        //        break;

        //        case 4:
        //            month = "April";
        //        break;

        //        case 5:
        //            month = "May";
        //        break;

        //        case 6:
        //            month = "June";
        //        break;

        //        default:
        //            month = "Enter a number between 1 and 6";
        //        break;
        //}

        //    return month;
        //}

    }
}