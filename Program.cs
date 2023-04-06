using _6AprelWorkTask;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book("namiq salam necesen"); 
        Book book1 = new Book("namiq salam necesen"); 
        Book book2 = new Book("namiq salam necesen"); 
        Book book3 = new Book("namiq salam necesen");
        LIbary libary = new LIbary();
        book.Price = 200;
        book.AuthorName = "eli";
    
     

        libary.AddBook(book);
        libary.AddBook(book1);
        libary.AddBook(book2);
        //libary.GetBook(1);
        //libary.GetBook(2);
        libary.GetBook(3);


    }
}