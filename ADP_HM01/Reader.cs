namespace ADP_HW01;

public class Reader
{
    public string FullName { get; }
    public int CardId { get; }
    private List<Book> borrowedBooks = new List<Book>();

    public Reader(string fullName, int cardId)
    {
        FullName = fullName;
        CardId = cardId;
    }

    public bool BorrowBook(Book book)
    {
        if (book.TakeCopy())
        {
            borrowedBooks.Add(book);
            return true;
        }
        return false;
    }

    public bool HasBook(Book book)
    {
        return borrowedBooks.Contains(book);
    }

    public void RemoveBook(Book book)
    {
        borrowedBooks.Remove(book);
    }
}
// END