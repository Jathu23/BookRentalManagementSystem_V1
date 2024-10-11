using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook : Book
    {
        public PrintedBook(string bookid, string title, string author, decimal rentalPrice,string ISBN,int NumberOfPages) 
            : base(bookid, title, author, rentalPrice)
        {
            this.ISBN = ISBN;
            this.NumberOfPages = NumberOfPages;

        }

        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }

        public void DisplayPrintedBookInfo()
        {
            Console.WriteLine($"{base.ToString()} ,ISBN: {ISBN} ,NumberOfPages: {NumberOfPages}");
        }

    }
}
