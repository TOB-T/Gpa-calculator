using System;
namespace GPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello: you are welcome to GPA calculator");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
            DisplayRs displayRs = new DisplayRs();

            Console.WriteLine("Type help to show options");
            Console.Write(">");
            string inputLine = Console.ReadLine().Trim();

            while (! inputLine.Equals("") && !inputLine.Equals("exit"))
            {
                if (inputLine.ToLower().Equals("add")) 
                {
                    displayRs.StartUpDisplay();
                }
                else if(inputLine.ToLower().Equals("print"))
                {
                    displayRs.DisplayResult();
                }
                else if (inputLine.ToLower().Equals("help"))
                {
                    displayRs.Help();
                }
                else
                {
                    Console.WriteLine("Command not recognised,type help to see all options");
                }
                Console.Write(">");
                inputLine = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
