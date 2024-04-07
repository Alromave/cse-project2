using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        AccountManager manager = new AccountManager();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create type");
            Console.WriteLine("2. Create new Account");
            Console.WriteLine("3. Add payment");
            Console.WriteLine("4. Add Address");
            Console.WriteLine("5. Add Tipology");
            Console.WriteLine("6. Check Account");
            Console.WriteLine("7. Exit");

            int choice;
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid choice!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    manager.CreateType();
                    break;
                case 2:
                    manager.CreateAccount();
                    break;
                case 3:
                    manager.AddPayment();
                    break;
                case 4:
                    manager.AddAddress();
                    break;
                case 5:
                    manager.AddTipology();
                    break;
                case 6:
                    manager.CheckAccount();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}


