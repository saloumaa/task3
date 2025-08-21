namespace task3_2
{
    class Book
    {
        string title;
        string author;
        string isbn;
        bool availability;

        public Book(string title, string author, string isbn, bool availability = true)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availability = availability;
        }
        public string GetTitle() => this.title;
        public string GetAuthor() => this.author;
        public string GetISBN()=>this.isbn;
        public bool IsAvailable()=> this.availability;
        public void SetAvailability(bool value)
        {
            this.availability = value;
        }

    }
    class Library
    {
        List<Book> books = new List<Book>();
        public string AddBook(Book book)
        {
            books.Add(book);
            return ($"Book '{book.GetTitle()}' , '{book.GetAuthor()}' , '{book.GetISBN()}' , '{book.IsAvailable()}' added successfully!");
        }
        public Book SearchBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].GetTitle() == title)
                {
                    return books[i];
                }
            }
            return null ;
        }
        public bool BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].GetTitle() == title)
                {
                    if (books[i].IsAvailable() == true)
                    {
                        books[i].SetAvailability(false);
                        Console.WriteLine($"Book {title} borrowed successfully."); 
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Book {title} is currently not available (already borrowed)."); 
                        return false;
                    }
                }
            }
            Console.WriteLine($"Book {title} not found in the library."); 
            return false;
        }
        public bool ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].GetTitle() == title)
                {
                    if (books[i].IsAvailable() == false)
                    {
                        books[i].SetAvailability(true);
                        Console.WriteLine($"Book {title} returned successfully.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Book {title} was not borrowed.");
                        return false;
                    }
                }
            }
            Console.WriteLine($"Book {title} not found in the library.");
            return false;
        }
        internal class Program
        {

            static void Main()
            {

                Library library = new Library();

                // Adding books to the library
                library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

                // Searching and borrowing books
                Console.WriteLine("Searching and borrowing books...");
                library.BorrowBook("Gatsby");
                library.BorrowBook("1984");
                library.BorrowBook("Harry Potter"); // This book is not in the library

                // Returning books
                Console.WriteLine("\nReturning books...");
                library.ReturnBook("Gatsby");
                library.ReturnBook("Harry Potter"); // This book is not borrowed

                Console.ReadLine();

            }
        }
    }
}
