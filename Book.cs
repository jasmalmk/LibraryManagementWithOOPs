using LibraryManagement;

public class Book : Library
{   
    public override void BorrowBook()
    {
        var book = Books.First(p => p.BookID == BookID);
        Console.WriteLine($"*** Book Name:{book.BookName} {(book.IsVailable ? "*** Available to borrow" : "Not Available to borrow")}");
        if (book.IsVailable)
        {
            Console.WriteLine($"Book Fee:{book.Fee}");
            book.IsVailable = false;
            book.BorrowDate = DateTime.Now;
            ListOfBooks();
        }
         Console.WriteLine("*****Borrow Book Completed****");
    }
    public override void ReturnBook()
    {
        var book = Books.First(p => p.BookID == BookID);
        Console.WriteLine($"*** Book Name:{book.BookName} {(!book.IsVailable ? "*** Book Return" : "Already Returned")}");
        if (!book.IsVailable)
        {
            var fee = IsDiscountAvailable(book.BorrowDate) ? DiscountFee(book.Fee??0) : book.Fee;
            Console.WriteLine($"Book Fee:{fee}");
            book.IsVailable = true;
            book.ReturnDate = DateTime.Now;
            ListOfBooks();
        }
           Console.WriteLine("*****Return Book Completed****");
    }
}