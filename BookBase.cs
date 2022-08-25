namespace LibraryManagement;

public class BookBase
{
    public int BookID { get; set; }
    public string? BookName { get; set; }
    public bool IsVailable { get; set; }
    public float? Fee { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime ReturnDate { get; set; }
}