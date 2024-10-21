using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ILoanable
    {
        int LoanPeriod { set; get; } //property
        string Borrower { set; get; } //property
        int Borrow(System.DateTime BorrowDate); //method
        int Return(System.DateTime ReturnDate); //method
    }

    public interface IPrintable
    {
        void Print(); //method
    }

    public class Book : ILoanable, IPrintable
    {
        public string author;
        public string title;
        public long iSBN;
        public Book(string Author, string Title, long ISBN)
        {
            author = Author;
            title = Title;
            iSBN = ISBN;
        }

        public int loanPeriod;
        public string borrower;
        public System.DateTime borrowDate;
        public System.DateTime returnDate;

        public int LoanPeriod //property
        {
            set
            {
                if (value <= 21)
                {
                    loanPeriod = value;
                }
                else
                {
                    System.Console.WriteLine("Loan Period of a book cannot be over 21 days");
                    loanPeriod = value;
                }
            }
            get
            {
                return loanPeriod;
                //return 21;
            }
        }
        public string Borrower //property
        {
            set
            {
                borrower = value;
            }
            get
            {
                return borrower;

            }
        }
        public int Borrow(System.DateTime BorrowDate) //method
        {
            borrowDate = BorrowDate;
            //System.DateTime borrowDate;
            //Convert.ToInt32(borrowDate);
            return 0;
        }
        public int Return(System.DateTime ReturnDate) //method
        {            
            if ((ReturnDate - borrowDate).TotalDays <= 21)
            {
                returnDate = ReturnDate;
            }
            else
            {
                System.Console.WriteLine("You have returned the book after 21 days. You need to pay a penalty fee.");
                returnDate = ReturnDate;
            }
            return 0;
        }

        public void Print() //method
        {
            System.Console.WriteLine("\nAuthor = " + author + ", Title = " + title + ", ISBN = " + iSBN + "\nLoan Period of the book is " + loanPeriod + " days. \nBorrower's name is " + borrower + "\nBorrow Date is " + borrowDate + "\nReturn Date is " + returnDate);
            //return author;
        }
    }


    public class DVD : ILoanable, IPrintable
    {
        public string director;
        public string title;
        public int lengthInMinutes;
        public DVD(string Director, string Title, int LengthInMinutes)
        {
            director = Director;
            title = Title;
            lengthInMinutes = LengthInMinutes;
        }

        public int loanPeriod;
        public string borrower;
        public System.DateTime borrowDate;
        public System.DateTime returnDate;

        public int LoanPeriod //property
        {
            set
            {
                if (value <= 7)
                {
                    loanPeriod = value;
                }
                else
                {
                    System.Console.WriteLine("Loan Period of a DVD cannot be over 7 days");
                    loanPeriod = value;
                }
            }
            get
            {
                return loanPeriod;
            }
        }
        public string Borrower //property
        {
            set
            {
                borrower = value;
            }
            get
            {
                return borrower;

            }
        }
        public int Borrow(System.DateTime BorrowDate) //method
        {
            borrowDate = BorrowDate;
            //System.DateTime borrowDate;
            //Convert.ToInt32(borrowDate);
            return 0;
        }
        public int Return(System.DateTime ReturnDate) //method
        {
            if ((ReturnDate - borrowDate).TotalDays <= 7)
            {
                returnDate = ReturnDate;
            }
            else
            {
                System.Console.WriteLine("You have returned the DVD after 7 days. You need to pay a penalty fee.");
                returnDate = ReturnDate;
            }
            return 0;
        }

        public void Print() //method
        {
            System.Console.WriteLine("\nDirector = " + director + ", Title = " + title + ", LengthInMinutes = " + lengthInMinutes + "\nLoan Period of the book is " + loanPeriod + " days. \nBorrower's name is " + borrower + "\nBorrow Date is " + borrowDate + "\nReturn Date is " + returnDate);
            //return author;
        }
    }

    public class CD : ILoanable, IPrintable
    {
        public string artist;
        public string title;
        public int numberOfTracks;
        public CD(string Artist, string Title, int NumberOfTracks)
        {
            artist = Artist;
            title = Title;
            numberOfTracks = NumberOfTracks;
        }

        public int loanPeriod;
        public string borrower;
        public System.DateTime borrowDate;
        public System.DateTime returnDate;

        public int LoanPeriod //property
        {
            set
            {
                if (value <= 14)
                {
                    loanPeriod = value;
                }
                else
                {
                    System.Console.WriteLine("Loan Period of a CD cannot be over 14 days");
                    loanPeriod = value;
                }
            }
            get
            {
                return loanPeriod;
            }
        }
        public string Borrower //property
        {
            set
            {
                borrower = value;
            }
            get
            {
                return borrower;

            }
        }
        public int Borrow(System.DateTime BorrowDate) //method
        {
            borrowDate = BorrowDate;
            //System.DateTime borrowDate;
            //Convert.ToInt32(borrowDate);
            return 0;
        }
        public int Return(System.DateTime ReturnDate) //method
        {
            if ((ReturnDate - borrowDate).TotalDays <= 14)
            {
                returnDate = ReturnDate;
            }
            else
            {
                System.Console.WriteLine("You have returned the CD after 14 days. You need to pay a penalty fee.");
                returnDate = ReturnDate;
            }
            return 0;
        }

        public void Print() //method
        {
            System.Console.WriteLine("\nArtist = " + artist + ", Title = " + title + ", NumberOfTracks = " + numberOfTracks + "\nLoan Period of the book is " + loanPeriod + " days. \nBorrower's name is " + borrower + "\nBorrow Date is " + borrowDate + "\nReturn Date is " + returnDate);
            //return author;
        }
    }


}
