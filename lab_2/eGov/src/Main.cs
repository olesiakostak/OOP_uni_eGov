using System;
using eGov.Models;

class Program
{
    static void Main()
    {
        int user_option = 0;
        Citizen user1 = null;
        Console.WriteLine("You're welcome to eGov!");

        while (true)
        {
            Console.WriteLine("Choose an option to continue:\n 1. Register \n 2. Show info \n 3. Exit");
            do 
            {
                if (!(int.TryParse(Console.ReadLine(), out user_option)))
                {
                    Console.WriteLine("Incorrect option");
                    user_option = 0;
                }
            }
            while (user_option == 0);

            switch (user_option)
            {
                case 1:
                    user1 = new Citizen();
                    user1.InputInfo();
                    break;
                case 2:
                    if (user1 != null)
                    {
                        user1.ShowInfo();
                    }
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}