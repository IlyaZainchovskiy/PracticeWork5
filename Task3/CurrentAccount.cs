using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accNum, string owner, decimal initialBalance)
            : base(accNum, owner, initialBalance)
        {
            base.New_Account();
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сума поповнення має бути позитивною.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"[Поточний] Рахунок {AccountNumber} поповнено на {amount:C}. Новий баланс: {Balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сума зняття має бути позитивною.");
                return;
            }
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"[Поточний] З рахунку {AccountNumber} знято {amount:C}. Новий баланс: {Balance:C}");
            }
            else
            {
                Console.WriteLine($"[Поточний] Недостатньо коштів на рахунку {AccountNumber}. Баланс: {Balance:C}");
            }
        }
        public void CloseAccount()
        {
            Console.WriteLine($"[Поточний] Ініційовано закриття рахунку {AccountNumber}...");
            base.Delete_Account();
        }

        public override void ShowBalance()
        {
            base.ShowBalance();
            Console.WriteLine("    Тип: Поточний");
        }
    }
}
