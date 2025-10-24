using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class DepositAccount : BankAccount
    {
        public double InterestRate { get; set; } 
        public DepositAccount(string accNum, string owner, decimal initialBalance, double interestRate)
            : base(accNum, owner, initialBalance)
        {
            InterestRate = interestRate;
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
            Console.WriteLine($"[Депозит] Рахунок {AccountNumber} поповнено на {amount:C}. Новий баланс: {Balance:C}");
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
                Console.WriteLine($"[Депозит] З рахунку {AccountNumber} знято {amount:C}. Новий баланс: {Balance:C}");
            }
            else
            {
                Console.WriteLine($"[Депозит] Недостатньо коштів на рахунку {AccountNumber}. Баланс: {Balance:C}");
            }
        }
        public void AddInterest()
        {
            decimal interest = Balance * (decimal)(InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"[Депозит] Нараховано відсотки {interest:C} (Ставка: {InterestRate}%) на рахунок {AccountNumber}. Новий баланс: {Balance:C}");
        }
        public void CloseAccount()
        {
            Console.WriteLine($"[Депозит] Ініційовано закриття рахунку {AccountNumber}...");
            base.Delete_Account();
        }

        public override void ShowBalance()
        {
            base.ShowBalance();
            Console.WriteLine($"    Тип: Депозитний, Ставка: {InterestRate}%");
        }
    }
}
