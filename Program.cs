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

            //Console.WriteLine(book1.ToString());
            Startpogram();

            //var book = new EBook("df","fjdhf","fh",1,23,"mp3");
            //book.DisplayDigitalBookInfo();
        }

        static void Startpogram()
        {
            var bookmanage = new BookManager();
            bool exitstatus = false;

            while (!exitstatus)
            {
                Console.WriteLine("Book Rental Management System:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Update a Book");
                Console.WriteLine("4. Delete a Book");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        bookmanage.CreateBook();
                        break;
                        case "2":
                        Console.Clear();
                        bookmanage.ReadBooks();
                        break;
                        case "3":
                        Console.Clear();
                        bookmanage.UpdateBook(); 
                        break;
                        case "4":
                        Console.Clear();
                        bookmanage.DeleteBook();
                        break;
                        case "5":
                        Console.Clear();
                        exitstatus = true;
                        break;

                }

            }


        }
    }
}
