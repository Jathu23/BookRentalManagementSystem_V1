using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class EBook : Book
    {
        public EBook(string bookid, string title, string author, decimal rentalPrice, double filesize, string format) 
            : base(bookid, title, author, rentalPrice)
        {
            this.filesize = filesize;
            this.format = format;
        }

        public double filesize { get; set; }
        public string format { get; set; }

        public void DisplayDigitalBookInfo()
        {
            Console.WriteLine($"{base.ToString()} ,filesize: {filesize} ,format: {format}");
        }
    }
}
