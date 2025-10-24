using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Document
    {
        public string Title { get; set; }

        public Document(string title)
        {
            Title = title;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"--- Документ: {Title} ---");
        }
    }
}
