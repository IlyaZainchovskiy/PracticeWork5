using System;

namespace Task1
{
    internal interface IBaseProperties
    {
        string Author { get; set; }
        DateTime Date { get; set; }
    }
    internal interface IRequisites : IBaseProperties
    {

        string Get_Requisites();
    }
    internal interface IDocument : IRequisites
    {
        decimal Get_Cost();
    }
}