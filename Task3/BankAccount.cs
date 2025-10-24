using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class BankAccount : IAccountManagement
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accNum, string owner, decimal initialBalance)
        {
            AccountNumber = accNum;
            OwnerName = owner;
            Balance = initialBalance;
        }
        public void New_Account()
        {
            Console.WriteLine($"[Base] Успішно відкрито новий рахунок: {AccountNumber} для {OwnerName}");
        }

        public void Delete_Account()
        {
            Console.WriteLine($"[Base] Видалено рахунок: {AccountNumber}. Фінальний баланс: {Balance:C}");
            Balance = 0; 
        }
        public virtual void ShowBalance()
        {
            Console.WriteLine($"Рахунок: {AccountNumber}, Власник: {OwnerName}, Баланс: {Balance:C}");
        }
    }
}
