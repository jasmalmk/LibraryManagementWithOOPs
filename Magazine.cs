using LibraryManagement;

public class Magazine : Library
{   
    public override void BorrowBook()
    {
        var magazines = Magazines.First(p => p.BookID == BookID);
        Console.WriteLine($"*** Magazine Name:{magazines.BookName} {(magazines.IsVailable ? "*** Available to borrow" : "Not Available to borrow")}");
        if (magazines.IsVailable)
        {
            Console.WriteLine($"Magazine Fee:{magazines.Fee}");
            magazines.IsVailable = false;
            magazines.BorrowDate = DateTime.Now;
            ListOfMagazines();
        }
        Console.WriteLine("*****Borrow Magazine Completed****");
    }
    public override void ReturnBook()
    {
        var magazines = Magazines.First(p => p.BookID == BookID);
        Console.WriteLine($"*** Magazines Name:{magazines.BookName} {(!magazines.IsVailable ? "*** Magazines Return" : "Already Returned")}");
        if (!magazines.IsVailable)
        {
            var fee = IsDiscountAvailable(magazines.BorrowDate) ? DiscountFee(magazines.Fee??0) : magazines.Fee;
            Console.WriteLine($"Magazines Fee:{fee}");
            magazines.IsVailable = true;
            magazines.ReturnDate = DateTime.Now;
            ListOfMagazines();
        }
         Console.WriteLine("*****Return Magazine Completed****");
    }
}