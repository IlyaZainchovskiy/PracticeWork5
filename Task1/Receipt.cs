using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Receipt : Document, IDocument
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public string Payer { get; set; }
        public decimal Amount { get; set; }

        public Receipt(string author, DateTime date, string payer, decimal amount)
            : base("Квитанція") 
        {
            Author = author;
            Date = date;
            Payer = payer;
            Amount = amount;
        }

        public string Get_Requisites()
        {
            return $"Реквізити квитанції: Платник - {Payer}, Касир - {Author}, Дата - {Date.ToShortDateString()}";
        }

        public decimal Get_Cost()
        {
            return Amount;
        }
        public override void PrintInfo()
        {
            base.PrintInfo(); 
            Console.WriteLine(Get_Requisites());
            Console.WriteLine($"Загальна сума: {Get_Cost():C}"); 
        }
    }
}
