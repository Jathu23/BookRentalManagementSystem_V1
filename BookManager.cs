using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        List<Book> Books = new List<Book>();

        public void CreateBook()
        {
            Console.WriteLine("Enter Book Title");
            string title =Console.ReadLine();
            Console.WriteLine("Enter Book Author");
            string author =Console.ReadLine();
            Console.WriteLine("Enter Book RentalPrice");
            decimal rentalprice = Convert.ToDecimal(Console.ReadLine());

            string bookid = Books.Count() + 1.ToString();

            Book book = new Book(bookid,title,author,rentalprice);
            Books.Add(book);
            Console.WriteLine("Book Add Sucessfully");

        }
        public void ReadBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No Books");
            }
            else
            {
                Console.WriteLine("Book List: ");
                foreach (Book book in Books)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public void UpdateBook()
        {

            Console.WriteLine("Enter Book Id For Update");
            string bid = Console.ReadLine();

            Book book = Books.Find(b => b.bookid == bid);

            Console.WriteLine("Enter New Title");
            book.title = Console.ReadLine();
            Console.WriteLine("Enter New Author");
            book.author = Console.ReadLine();
            Console.WriteLine("Enter New Rental Price");
            book.rentalPrice = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Book update Su");

        }
    }
}
