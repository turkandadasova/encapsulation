
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;

namespace ConsoleApp30
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Salam");
            Book book = new Book( 15, "12", "book", 23, "genre");
            Book book1 = new Book(45, "567", "book1", 66, "genre1");
            Book book2 = new Book(98, "887", "book2", 90, "genre2");
            book.ShowInfo();
            Book[] newbooks = {book, book1, book2};
            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.ShowAllBooks();




        }
    }

    public class Product
    {
        int _count;
        int _price;
        public string No;
        public string Name;

        public Product(int price, string no, string name, int count)
        {
            No = no;
            Name = name;
        }

        public Product(int count, int price, string no, string name)
        {
            _count = count;
            _price = price;
            No = no;
            Name = name;
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0 && value < 50)
                {
                    _price = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }

        }
    }
        public class Book : Product
        {
            public string Genre;


            public Book(int price, string no, string name, int count, string genre) : base(price, no, name,count)
            {
                Genre = genre;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"adi: {Name}, qiymeti: {Price}, no: {No}, janr: {Genre}");
            }



        }

        public class Library
        {
             Book[] Books=new Book[0];

            public void AddBook(Book book)
            {
                Book[] newbooks = new Book[Books.Length + 1];
                for (int i = 0; i < Books.Length; i++)
                {
                    newbooks[i] = Books[i];
                }
                newbooks[Books.Length - 1] = book;
                Books = newbooks;
            }


            public Book GetFiltredBooks(string genre)
            {
                Book foundBook = null;
                foreach (var item in Books)
                {
                    if (item.Genre == genre)
                    {
                        foundBook = item;
                        return foundBook;
                    }
                }
                return foundBook;
            }
            public void GetFiltredBooks(int minPrice, int maxPrice)
            {

            }


            public void ShowAllBooks(Book book)
            {
              Book[] newbooks=new Book[Books.Length + 1];
             for (int i = 0; i < Books.Length; i++)
             {
                newbooks[i]=Books[i];
             }
                newbooks[newbooks.Length - 1] = book;
                Books=newbooks;

            }


        }



    
}
