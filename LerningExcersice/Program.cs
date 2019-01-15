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
                            // Call yoyr next assigment here!
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
                // Mats
                // Mats
            }
        }
        private static void RunExcerciseOne()
        {
            Console.ResetColor();
            Console.Write("Firstname? ");
            string strFirstname = Console.ReadLine();
            Console.Write("Lastname? ");
            string strLastname = Console.ReadLine();
            Console.WriteLine("Hello " + strFirstname + " " + strLastname + "! I’m glad to inform you that you are the test subject of my very first assignment!");
            Console.ReadKey();

        }
        private static void RunExcerciseTwo()
        {
            Console.ResetColor();
            //DateTime.Now.ToString("yy-MM-dd")
            Console.WriteLine("Todays date is: {0}", DateTime.Now.ToString("yy-MM-dd"));
            DateTime d = GetTomorrow();
            Console.WriteLine("Tomorrows date is: {0}", d);
            DateTime y = GetYesterday();
            Console.WriteLine("Yesterdays date was: {0}", y);
            Console.WriteLine(DateTime.Now);
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
    }
}
