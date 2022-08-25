
using LibraryManagement;

var libary=new Library();
libary.ListOfBooks();

var book=new Book();
book.BookID=100;
book.BorrowBook();

book.BookID=200;
book.BorrowBook();

book.BookID=100;
book.ReturnBook();

libary.ListOfMagazines();
var magazine=new Magazine();
magazine.BookID=300;
magazine.BorrowBook();

magazine.BookID=200;
magazine.BorrowBook();

magazine.BookID=200;
magazine.ReturnBook();