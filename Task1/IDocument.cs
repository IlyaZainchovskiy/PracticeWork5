using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal interface IDocument
    {
        string Author { get; set; }
        DateTime Date { get; set; }
        string Get_Requisites();
        decimal Get_Cost();
    }
}
