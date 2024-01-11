using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public  class Manger : IBook
    {
        private List<Book> _books = new();


        public void AddBook(string name, int type, int count, int price, int ID)
        {
            if (type == 1)
            {
                var saleBook = new SellBook();
                saleBook.Name = name;
                saleBook.BookID = ID;
                saleBook.SetCount(count);
                saleBook.SetPrice(price);
                _books.Add(saleBook);
            }

            if (type == 2)
            {
                var rentBook = new RentBook();
                rentBook.Name = name;
                rentBook.BookID = ID;
                rentBook.SetPrice(price);
                rentBook.SetCount(count);
                _books.Add(rentBook);
            }
        }

        public void RemoveBook(int BookID)
        {
            Book book = _books.Find(_ => _.BookID == BookID);
            if (book is null)
            {
                throw new Exception("Book not found with this ID");
            }
            _books.Remove(book);
        }

        public void DisplayAllBook()
        {
            Console.WriteLine("*********************** All Books ************************");
            foreach (var book in _books)
            {
                var bookType = (book is RentBook) ? "Rent" : "Sale";
                Console.WriteLine($"Book ID: {book.BookID}, Name: {book.Name}, Type: {bookType}, Count: {book.Count}, Price: {book.Price:C}");
            }
            Console.WriteLine("**********************************************************");
        }
    }
}