using System;

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
                    Console.ForegroundColor = ConsoleColor.Green;
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
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This is not a valid assigment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is not a valid assigment number!");
                    Console.ResetColor();
                }
                //Console.WriteLine("Hello World!");
                //Console.ReadKey(); 
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
            string fox4 = fox3.Insert(30, "lazy ");
            return fox4;
        }

        static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }


    }
}
