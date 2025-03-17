using System;
using eGov.Models;

class Program
{
    static void Main()
    {
        Citizen? user1 = null;
        Console.WriteLine("You're welcome to eGov!");

        while (true)
        {
            Console.WriteLine("Choose an option to continue:\n 1. Register \n 2. Show info \n 3. Exit");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.KeyChar)
            {
                case '1':
                    user1 = new Citizen();
                    user1.InputInfo();
                    break;
                case '2':
                    if (user1 != null)
                        user1.ShowInfo();
                    else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You are not registered");
                            Console.ResetColor();
                        }
                    break;
                case '3':
                    break;
                default:
                    break;
            }
            if (keyInfo.KeyChar == '3') break;
        }
    }
}