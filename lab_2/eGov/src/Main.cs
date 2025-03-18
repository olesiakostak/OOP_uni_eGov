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
            Console.WriteLine("Choose an option to continue:\n 1. Register \n 2. Show general info");
            Console.WriteLine(" 3. Get info about the place of residence \n 4. Exit");
            char user_input = char.ToLower(Console.ReadKey(true).KeyChar); 

            switch (user_input)
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
                    if (user1 == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are not registered");
                        Console.ResetColor();
                    }
                    else if (user1.GetAddress() == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have not entered a place of recidence. Do you want to enter? (y/n)");
                        Console.ResetColor();
                        char _user_input = char.ToLower(Console.ReadKey(true).KeyChar);
                        if (_user_input == 'y')
                        {
                            user1.InputAddress();
                        }
                    }
                    else
                    {
                        user1.GetAddress().ShowAddress();
                    }
                    break;
                default:
                    break;
            }
            if (user_input == '4') break;
        }
    }
}