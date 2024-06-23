namespace Task_2;

// Створіть додаток для обліку книг, який зберігатиме наступну
// інформацію:
    //  назва книги;
    //  П.І.Б. автора;
    //  жанр книги;
    //  рік видання
// Для зберігання даних книг використовуйте клас
// LinkedList<T>.
    // Додаток має надавати таку функціональність:
    //  додавати книги;
    //  видаляти книги;
    //  змінювати інформацію про книги;-
    //  пошук книг за параметрами;-
    //  вставити книги у початок списку;
    //  вставити книги у кінець списку;
    //  вставити книги у певну позицію;
    //  видалити книги з початку списку;
    //  видалити книги з кінця списку;
    //  видалити книги з певної позиції.

class Program
{
    static void Main(string[] args)
    {
        Bookkeeping.AddBook(new Book("Book1", new FullName("John", "Doe", ""), "Fantasy", 2000));
        Bookkeeping.AddBook(new Book("Book2", new FullName("Jane", "Smith", ""), "Science Fiction", 1995));
        Bookkeeping.AddBook(new Book("Book3", new FullName("Michael", "Johnson", ""), "Thriller", 2010));
        Bookkeeping.AddBook(new Book("Book4", new FullName("Emily", "Brown", ""), "Romance", 2020));
        Bookkeeping.AddBook(new Book("Book5", new FullName("David", "Lee", ""), "Mystery", 2005));

        Bookkeeping.AddBookByPosition(new Book("Book6", new FullName("David", "Lee", ""), "Mystery", 2005),3);
        Bookkeeping.RemoveBookByPosition(5); // Book4
        Bookkeeping.Show();
        
        Console.WriteLine("-----Change-----");
        try
        {
            Bookkeeping.ChageBookData(book => book.Name == "Book2", (book) => { book.Year = 3;});
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("-----Find-----");
        try
        {
            Console.WriteLine(Bookkeeping.FindBook(book => book.Name == "Book2"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}