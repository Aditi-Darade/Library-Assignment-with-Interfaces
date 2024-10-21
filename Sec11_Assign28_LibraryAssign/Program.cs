using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Book;

namespace Sec11_Assign28_LibraryAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book (Author: "C. S. Lewis", Title: "The Chronicles of Narnia", ISBN: 9780000355812); //string Author, string Title, int ISBN
            b1.LoanPeriod = 20;
            b1.Borrower = "Asa";
            b1.Borrow(System.Convert.ToDateTime("2000-05-25"));
            b1.Return(DateTime.Now);                
            b1.Print();
            System.Console.WriteLine("-------------------------------------------------\n");

            DVD d1 = new DVD("Henry Selick", "Coraline", 115); //string Director, string Title, int LengthInMinutes
            d1.LoanPeriod = 25;
            d1.Borrower = "Sam";
            d1.Borrow(System.Convert.ToDateTime("2024-05-25"));
            d1.Return(DateTime.Now);
            d1.Print();
            System.Console.WriteLine("-------------------------------------------------\n");

            CD c1 = new CD("Gracie Abrams", "minor", 7); //string Artist, string Title, int NumberOfTracks
            c1.LoanPeriod = 30;
            c1.Borrower = "Row";
            c1.Borrow(System.Convert.ToDateTime("2024-10-5"));
            c1.Return(DateTime.Now);
            c1.Print();
            System.Console.WriteLine("-------------------------------------------------\n");

            System.Console.ReadKey();
        }
    }
}
