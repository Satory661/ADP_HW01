namespace ADP_HW01;

internal class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("The Way I Am", "Eminem", 2008, 2);
        Book book2 = new Book("How to Win Friends and Influence People", "Dale Carnegie", 1936, 1);
        
        library.AddBook(book1);
        library.AddBook(book2);

        Reader reader1 = new Reader("Sponge BOB.", 101);
        Reader reader2 = new Reader("Shrek.", 102);
        
        library.AddReader(reader1);
        library.AddReader(reader2);
        
        library.GiveBook(book1, reader1);
        library.GiveBook(book2, reader2);
        library.GiveBook(book2, reader1); 
        
        library.ReturnBook(book1, reader1);
        library.ReturnBook(book2, reader2);
    }
}
// END