using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Validator
    {

        public static int InputValidator()
        {
            string input = Console.ReadLine().ToLower();

            while (true)
            {
                if (input == "r")
                {
                    return 0;
                }
                else if (input == "p")
                {
                    return 1;
                }
                else if (input == "s")
                {
                    return 2;
                }
                else
                {
                    Console.Write("invalid: ");
                    input = Console.ReadLine();
                }
            }
        }

        public static int OpponentSelection()
        {
            while (true)
            {
                string test = Console.ReadLine();

                if (test == "1")
                {
                    return 1;
                }
                else if (test == "2")
                {
                    return 2;
                }
                else
                {
                    Console.WriteLine("Entry invalid");
                    test = Console.ReadLine();
                }
            }
        }

        public static string Continue()
        {
            while (true)
            {
                Console.Write("\nWould you like to play again? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "\nExcellent! Let's Go!!.";
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine($"Bye! ");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
        }

        public static string NameValidator()
        {
            string input = Console.ReadLine();

            while (true)
            {
                if (!input.All(Char.IsLetter))
                {
                    Console.Write("Only actual names please: ");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    return input;
                }
            }
        }
    }
}
