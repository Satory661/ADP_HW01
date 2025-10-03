namespace ADP_HW01;

public class Library
{
    private List<Book> books = new List<Book>();
    private List<Reader> readers = new List<Reader>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddReader(Reader reader)
    {
        readers.Add(reader);
    }

    public void GiveBook(Book book, Reader reader)
    {
        if (reader.BorrowBook(book))
        {
            Console.WriteLine($"{reader.FullName} взял книгу: {book.BookName}");
        }
        else
        {
            Console.WriteLine($"Книга {book.BookName} недоступна для {reader.FullName}");
        }
    }

    public void ReturnBook(Book book, Reader reader)
    {
        if (reader.HasBook(book))
        {
            book.ReturnCopy();
            reader.RemoveBook(book);
            Console.WriteLine($"{reader.FullName} вернул книгу: {book.BookName}");
        }
        else
        {
            Console.WriteLine($"{reader.FullName} не имеет книги: {book.BookName}");
        }
    }
}
// END