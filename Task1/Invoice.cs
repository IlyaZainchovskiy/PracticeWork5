using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Invoice : Document, IDocument
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string FromCompany { get; set; }
        public string ToCompany { get; set; }
        public List<(string Item, int Quantity, decimal Price)> Items { get; set; }
        public Invoice(string author, DateTime date, string from, string to)
            : base("Накладна") 
        {
            Author = author;
            Date = date;
            FromCompany = from;
            ToCompany = to;
            Items = new List<(string, int, decimal)>(); 
        }
        public string Get_Requisites()
        {
            return $"Реквізити накладної: Відправник - {FromCompany}, Отримувач - {ToCompany}, Відповідальний - {Author}, Дата - {Date.ToShortDateString()}";
        }

        public decimal Get_Cost()
        {
            return Items.Sum(item => item.Quantity * item.Price);
        }
        public override void PrintInfo()
        {
            base.PrintInfo(); 
            Console.WriteLine(Get_Requisites());
            Console.WriteLine("Список товарів:");
            foreach (var (Item, Quantity, Price) in Items)
            {
                Console.WriteLine($"- {Item}: {Quantity} шт. x {Price:C} = {Quantity * Price:C}");
            }
            Console.WriteLine($"Загальна вартість: {Get_Cost():C}");
        }
    }
}
