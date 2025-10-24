using System;
using System.Reflection.Metadata;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Receipt receipt = new Receipt("Касир Петя", DateTime.Now, "Катерина.", 150.75m);

            Invoice invoice = new Invoice("Комірник Іван.", new DateTime(2025, 10, 24), "ТОВ \"Світанок\"", "ПП \"Надія\"");
            invoice.Items.Add(("Ноутбук \"ASUS\"", 1, 25000m));
            invoice.Items.Add(("Миша оптична", 2, 450m));
            invoice.Items.Add(("Кабель HDMI 2м", 1, 320.50m));

            Console.WriteLine("--- Квитанція ---");
            receipt.PrintInfo();

            Console.WriteLine("\n--- Накладна ---");
            invoice.PrintInfo();

            IDocument doc1 = receipt;
            IDocument doc2 = invoice;

            IDocument[] documents = { doc1, doc2 };

            foreach (var doc in documents)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Автор документа: {doc.Author}");
                Console.WriteLine($"Дата документа: {doc.Date.ToShortDateString()}");
                Console.WriteLine($"Реквізити: {doc.Get_Requisites()}");
                Console.WriteLine($"Загальна вартість: {doc.Get_Cost():C}");

                if (doc is Document)
                {
                    (doc as Document).PrintInfo(); 
                }
            }
        }
    }
}