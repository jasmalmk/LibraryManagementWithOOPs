namespace LibraryManagement;

public class Library
{
    public readonly List<BookBase> Books;
    public readonly List<BookBase> Magazines;
    public int BookID { get; set; }

    public Library()
    {
        Books = new List<BookBase>{
            new BookBase{BookID=100,BookName="Alchemist",IsVailable=true,Fee=100},
            new BookBase{BookID=200,BookName="Harry Portar",IsVailable=true,Fee=250},
            new BookBase{BookID=300,BookName="Da Vinci Code",IsVailable=true,Fee=80},
        };

        Magazines = new List<BookBase>{
            new BookBase{BookID=100,BookName="Reader's Digest",IsVailable=true,Fee=600},
            new BookBase{BookID=200,BookName="Us Weekly",IsVailable=true,Fee=550},
            new BookBase{BookID=300,BookName="National Geographic",IsVailable=true,Fee=180},
        };
    }
    #region list
    public void ListOfBooks()
    {
        Console.WriteLine("****List of Books*****");
        Books.ForEach(i => Console.WriteLine($"BookId: {i.BookID}\t Book Name: {i.BookName} \t Book IsAvailable: {(i.IsVailable ? "Available" : "Not Available")}"));
    }
     public void ListOfMagazines()
    {
        Console.WriteLine("****List of Magazines*****");
        Magazines.ForEach(i => Console.WriteLine($"Magazine Id: {i.BookID}\t Magazine Name: {i.BookName} \t Magazine IsAvailable: {(i.IsVailable ? "Available" : "Not Available")}"));
    }
    #endregion

    public virtual void BorrowBook() { }
    public virtual void ReturnBook() { }

    public static bool IsDiscountAvailable(DateTime BorrowDate)
    {
        if ((DateTime.Now.Hour - BorrowDate.Hour) <= 24)
        {
            Console.WriteLine("***Fee Discount available");
            return true;
        }
        return false;
    }
    public static float DiscountFee(float fee)
    {
        return (fee * 20)/100;
    }
}
