using System;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        void Run()
        {
            int choice = 0;

            WritePrompt();
            choice = ReadChoice();
            while (choice == -1)
            {
                WritePrompt();
                choice = ReadChoice();
            }
            WriteChoice(choice);
        }

        void WritePrompt()
        {
            Console.WriteLine("Couch's Copy");
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1] IT 145\n[2] IT 200\n[3] IT 201\n[4] IT 270\n[5] IT 315\n[6] IT 328\n[7] IT 330");
            Console.Write("Enter your choice: ");
        }

        int ReadChoice()
        {
            string s = Console.ReadLine();
            int choice;
            if (int.TryParse(s, out choice))
            {
                if (choice >= 1 && choice <= 7)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return -1;
            }
        }

        void WriteChoice(int choice)
        {
            Console.WriteLine("Your choice is {0}", choice);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}

