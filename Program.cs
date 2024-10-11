using BookRentalManagementSystem_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("001", "PONNIYIN SELVAN", "kalki", 10);

            Console.WriteLine(book1.ToString());
        }
    }
}
