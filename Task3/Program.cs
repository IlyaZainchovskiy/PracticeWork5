using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Робота з Поточним Рахунком ---");
            CurrentAccount current = new CurrentAccount("UA-CUR-001", "Олена Коваль", 1000m);
            current.ShowBalance();

            Console.WriteLine("\nОперація:");
            current.Deposit(500m);  
            current.Withdraw(300m); 
            current.Withdraw(1500m);
            current.ShowBalance();

            Console.WriteLine("\n");


            Console.WriteLine("--- Робота з Депозитним Рахунком ---");
            DepositAccount deposit = new DepositAccount("UA-DEP-002", "Андрій Шевченко", 5000m, 12.5);
            deposit.ShowBalance();

            Console.WriteLine("\nОперації:");
            deposit.Deposit(2000m);    
            deposit.AddInterest();     
            deposit.Withdraw(1000m);   
            deposit.ShowBalance();

            Console.WriteLine("\n--- Закриття рахунків ---");

            Console.WriteLine("Закриття поточного рахунка:");
            current.CloseAccount(); 
            current.ShowBalance(); 

            Console.WriteLine("\nЗакриття  депозитного рахунка:");
            deposit.CloseAccount(); 
            deposit.ShowBalance();  
        }
    }
}
