namespace Task_2;

public static class Bookkeeping
{
    private static LinkedList<Book> _listBooks = new LinkedList<Book>();

    public static void AddBook(Book book) => _listBooks.AddLast(book);
    public static void AddBookStart(Book book) => _listBooks.AddFirst(book);
    public static void AddBookEnd(Book book) => _listBooks.AddLast(book);
    public static void AddBookByPosition(Book book, int position)
    {
        if (position < 0 && position > _listBooks.Count)
            throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException");

        var node = _listBooks.First;
        for (int i = 1; i < position; i++)
            node = node.Next;
        
        _listBooks.AddBefore(node, book);
    }
    
    public static void RemoveBook() => _listBooks.RemoveLast();
    public static void RemoveBookStart(Book book) => _listBooks.RemoveFirst();
    public static void RemoveBookEnd(Book book) => _listBooks.RemoveLast();
    public static void RemoveBookByPosition(int position)
    {
        if (position < 0 && position > _listBooks.Count)
            throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException");

        var node = _listBooks.First;
        for (int i = 1; i < position; i++)
            node = node.Next;
        
        _listBooks.Remove(node);
    }

    public static Book FindBook(Predicate<Book> predicate)
    {
        var node = _listBooks.First;
        while (node != null)
        {
            if (predicate(node.Value))
            {
                return node.Value;
            }
            node = node.Next;
        }

        throw new Exception("Book not found");
    }
    
    public static void ChageBookData(Predicate<Book> predicate, Action<Book> action)
    {
        Book book = FindBook(predicate);
        action(book);
    }
    
    public static void Show()
    {
        foreach (var book in _listBooks)
            Console.WriteLine(book);
    }
    
}