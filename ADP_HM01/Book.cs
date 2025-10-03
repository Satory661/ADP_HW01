namespace ADP_HW01;

public class Book
{
    public string BookName { get; }
    public string Writer { get; }
    public int Code { get; }
    public int Quantity { get; private set; }

    public Book(string bookName, string writer, int code, int quantity)
    {
        BookName = bookName;
        Writer = writer;
        Code = code;
        Quantity = quantity;
    }

    public bool TakeCopy()
    {
        if (Quantity > 0)
        {
            Quantity--;
            return true;
        }
        return false;
    }

    public void ReturnCopy()
    {
        Quantity++;
    }
}
// END