using System;

namespace Mastermind
{
    class Mastermind
    {
        static void Main(string[] args)
        {
            Random GenRandom = new Random();
            int t = 0, r, c1 = GenRandom.Next(1, 6), c2 = GenRandom.Next(1, 6), c3 = GenRandom.Next(1, 6), c4 = GenRandom.Next(1, 6);
            bool w = false;
            string Input, Code = Convert.ToString(c1); Code += c2; Code += c3; Code += c4;
            while (t != 10)
            {
                t++;
            Unepic:
                Console.Clear();
                Console.WriteLine("You have {0} turn(s) left.", 11 - t);
                Console.WriteLine("Guess the code E.g 1561: ");
                Input = Console.ReadLine();
                if (Input.Length != 4) goto Unepic; // Checks if input is 4 characters long
                try { Convert.ToInt16(Input); Convert.ToString(Input); } catch (FormatException) { goto Unepic; } // Checks if input is only numbers
                if (Input == Code) { w = true; goto End; }; // Checks if you've won
                if (Input.Contains("0") || Input.Contains("7") || Input.Contains("8") || Input.Contains("9")) { goto Unepic; } // Checks if it has any digits that are 0 or above 7
                r = -1;
                while (r != 3)
                {
                    r++;
                    if (Input[r] == Code[r]) Console.Write("+"); else Console.Write("-"); // Checks if a digit of the input is equal to a digit of the code
                }
                Console.WriteLine();
                Console.Write("Press any key to continue.");
                Console.ReadKey(true);
            }
        End:;
            Console.Clear();
            if (w == true) { Console.WriteLine("You won! The code you guessed was {0}.", Code); } else { Console.WriteLine("You lost! The code you couldnt guess was {0}.", Code); };
            Console.ReadKey(true);
        }
    }
}
