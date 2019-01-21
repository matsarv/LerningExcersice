using System;

public static class Globals
{
    public static String globalcolor = "Red"; // Modifiable
}

namespace LerningExcersice
{



    class Program
    {
        static void Main(string[] args)
        {
            

            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assigment number (or -1 to exit): ");
                    var assigmentChoise = int.Parse(Console.ReadLine() ?? "");
                    //Console.ForegroundColor = ConsoleColor.Green;
                    switch (assigmentChoise)
                    {
                        case 1:
                            RunExcerciseOne();
                            break;

                        case 2:
                            RunExcerciseTwo();
                            break;

                        case 3:
                            string FirstLastName = RunExcerciseTree();
                            Console.WriteLine("Your name is " + FirstLastName );
                            break;

                        case 4:
                            string str = "The quick fox Jumped Over the DOG";  // code here 
                            string FixWord = RunExcerciseFour(str);
                            Console.WriteLine(str);
                            Console.WriteLine(FixWord);
                            break;

                        case 5:
                            string manipulatedString = RunExcerciseFive();
                            Console.WriteLine(manipulatedString);
                            break;

                        case 6:

                            //int a = 8;
                            //int b = 1;
                            //double average = (a + b) / (double) 2;
                            //Console.WriteLine(average);

                            RunExcerciseSix();
                            break;

                        case 7:
                            RunExcerciseSeven();
                            break;

                        case 8:
                            RunExcerciseEight();
                            break;

                        case 9:
                            RunExcerciseNine();
                            break;

                        case 10:
                            RunExcerciseTen();
                            break;

                        case 11:
                            RunExcerciseEleven();
                            break;

                        case 12:
                            RunExcerciseTwelve();
                            break;

                        case 13:
                            RunExcercise13();
                            break;

                        case -1:

                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This is not a valid assigment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nHit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is not a valid assigment number!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExcerciseOne()
        {
            Console.ResetColor();
            Console.Write("Enter Firstname? ");
            string strFirstname = Console.ReadLine();
            Console.Write("Enter Lastname? ");
            string strLastname = Console.ReadLine();
            Console.WriteLine("Hello " + strFirstname + " " + strLastname + "! I’m glad to inform you that you are the test subject of my very first assignment!");
            Console.ReadKey();
        }

        private static void RunExcerciseTwo()
        {
            Console.ResetColor();
            Console.WriteLine("Todays date is: {0}", DateTime.Now.ToString("yy-MM-dd"));
            DateTime d = GetTomorrow();
            Console.WriteLine("Tomorrows date is: {0}", d.ToString("yy-MM-dd"));
            DateTime y = GetYesterday();
            Console.WriteLine("Yesterdays date was: {0}", y.ToString("yy-MM-dd"));
            Console.ReadKey();
        }

        static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        private static string RunExcerciseTree()
        {
            Console.ResetColor();
            Console.Write("Enter Firstname? ");
            string strFirstname = Console.ReadLine();
            Console.Write("Enter Lastname? ");
            string strLastname = Console.ReadLine();

            string FirstLast =  strFirstname + " " + strLastname;
            return FirstLast;
        }

        private static string RunExcerciseFour(string a)
        {
            //The quick fox Jumped Over the DOG
            //The brown fox jumped over the lazy dog
            string fox1 = a.ToLower();
            string fox2 = char.ToUpper(fox1[0]) + fox1.Substring(1);
            string fox3 = fox2.Replace("quick ", "brown ");
            String fox4 = fox3.Insert(30, "lazy ");
            return fox4;
        }

        private static string RunExcerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            int i = str.IndexOf('[');
            string str1= str.Substring(i);
            string str2 = str1.Remove(3, 4);
            string str3 = str2.Insert(6, ",6,7,8,9,10");
            //string theend2 = theend.Length -1;
            return str3;
        }

        private static void RunExcerciseSix()
        {
            Console.ResetColor();
            Console.Write("Enter first number? ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number? ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)  {
                int numberDiff = (firstNumber - secondNumber);
                int numberSum = firstNumber + secondNumber;
                int numberProd = firstNumber * secondNumber;

                double numberRatio = firstNumber / (double)secondNumber;

                Console.WriteLine ("First number highest: " + firstNumber);
                Console.WriteLine("Seconnd number lowest: " + secondNumber);
                Console.WriteLine ("Difference: " + numberDiff);
                Console.WriteLine("Sum: " + numberSum);
                Console.WriteLine("Product:" + numberProd);
                Console.WriteLine("Ration: " + numberRatio);
            }
            else
            {
                int numberDiff = (firstNumber - secondNumber);
                int numberSum = firstNumber + secondNumber;
                int numberProd = firstNumber * secondNumber;

                double numberRatio = firstNumber / (double)secondNumber;

                Console.WriteLine("First number lowest: " + firstNumber);
                Console.WriteLine("Seconnd number highest: " + secondNumber);
                Console.WriteLine("Difference: " + numberDiff);
                Console.WriteLine("Sum: " + numberSum);
                Console.WriteLine("Product:" + numberProd);
                Console.WriteLine("Ration: " + numberRatio);
            }
        }

        private static void RunExcerciseSeven()
        {
            Console.WriteLine("Please write the radius of your circle: ");
            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            
            //double area = pi * (radius * radius);
            double area = pi * Math.Pow(radius, 2);
            Console.WriteLine("The Area is {0:0.00}" , area);

            double volume = (4 * pi * Math.Pow(radius, 3)) / 3;
            Console.WriteLine("The Volume is {0:0.00}", volume);
        }

        private static void RunExcerciseEight()
        {

            Console.WriteLine("Please write a decimal number: ");
            // number = double.Parse(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());

            double square = Math.Sqrt(number);
            double powerof2 = Math.Pow(number, 2);
            double powerof10 = Math.Pow(number, 10);

            Console.WriteLine("Square Root of number {0} is {1}", number, square);
            Console.WriteLine("Power of 2 of number {0} is {1}", number, powerof2);
            Console.WriteLine("Power of 10 of number {0} is {1}", number, powerof10);
        }

        private static void RunExcerciseNine()
        {
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("Welcom " + yourName +",\nWhen are you born? (year)");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            //double birtYear = double.Parse(Console.ReadLine() ?? "");
            int age = DateTime.Now.Year - birthYear;

            //DateTime birthDay = new DateTime(birthYear,01,01);

            //int nowYear = DateTime.Now.Year;
            //Console.WriteLine(birthDay.ToShortDateString());
            //Console.WriteLine(birthDay.ToString("YYYY"));
            //Console.WriteLine(nowYear);

            //Console.WriteLine(age);

            if (age >= 18)
            {
                Console.Write("Do you want to order a bear? (yes/no)");
                string askBeer = (Console.ReadLine() ?? "");

                if (askBeer == "y")
                {
                    Console.WriteLine("Here is your beer!");
                }
                else
                {
                    Console.Write("Do you want to order a coke? (yes/no)");
                    string askCoke = (Console.ReadLine() ?? "");

                    if (askCoke == "y")
                    {
                        Console.Write("Here is your coke!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we only have beer and coke!");
                    }
                }

            }
            else
            {
                Console.Write("Do you want to order a coke? (yes/no)");
                string askCoke = (Console.ReadLine() ?? "");

                if (askCoke == "y")
                {
                    Console.WriteLine("Here is your coke!");
                }
                else
                {
                    Console.WriteLine("Sorry, we only have beer and coke!");
                }
            }

        }


        private static void RunExcerciseTen()
        {

            Console.Write("Enter assigment number (1,2,3): ");
            var assigmentChoise = int.Parse(Console.ReadLine() ?? "");
            //Console.ForegroundColor = ConsoleColor.Green;
            switch (assigmentChoise)
            {
                case 1:
                    CheckAndDivision();
                    break;

                case 2:
                    string str = "The quick fox Jumped Over the DOG";  // code here 
                    string FixWord = RunExcerciseFour(str);
                    Console.WriteLine(str);
                    Console.WriteLine(FixWord);
                    break;

                case 3:
                    //Console.WriteLine(Globals.globalcolor);
                    if (Globals.globalcolor == "Red")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This is Red ");
                        Console.ResetColor();

                        Globals.globalcolor = "Green";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("This is Green ");
                        Console.ResetColor();

                        Globals.globalcolor = "Red";
                    }

                    break;

            }
        }

        // Belongs to RunExcerciseTen
        private static void CheckAndDivision()
        {
            Console.Write("Enter number one: ");
            var numberOne = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter number two: ");
            var numberTwo = int.Parse(Console.ReadLine() ?? "");

            if (numberTwo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Divided by 0 is not allowed!");
                Console.ResetColor();
            }
            else
            { 
                double output = numberOne / numberTwo;
                Console.WriteLine (output);
            }

            return;
        }

        private static void RunExcerciseEleven()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine() ?? "");

            if (number > 0)
            {
                for (int i=0; i<=number; i++)
                {
                    if (IsOdd(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                }

                Console.WriteLine("----------------------------------------");

                for (int i = number; i >= 0; i--)
                {
                    if (IsOdd(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Divided by 0 is not allowed!");
                Console.ResetColor();
            }

        }
        // Belongs to RunExcerciseEleven
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private static void RunExcerciseTwelve()
        {
            Console.Write("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(i + "\t");
                Console.ResetColor();
                for (int t = 2; t <= 10; t++)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(i*t + "\t");
                    Console.ResetColor();
                }
                Console.Write(" \n\n");
            }
        }

        private static void RunExcercise13()
        {
            Random rnd = new Random();
            int card = rnd.Next(500);     // creates a number between 0 and 500
            bool stay = true;

            //Console.WriteLine(card);
            int i = 0;

            while (stay)
            {
                Console.Write("Enter number between 1 and 500? ");
                int number = int.Parse(Console.ReadLine() ?? "");
                if (number > card)
                {
                    Console.Write("You guess was to big! ");
                    i = i + 1;
                }
                else if (number < card)
                {
                    Console.Write("You guess was to low! ");
                    i = i + 1;
                }
                else
                {
                    Console.Write("Yee, you guess is correct! You tried guessing " + i + " times.\n");
                    stay = false;
                }
            }
        }





    }
}
