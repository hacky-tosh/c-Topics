namespace LINQ;

public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {


        return new List<Book>
        {
            new Book() { Title = "book1", Price = 5 },
            new Book() { Title = "book2", Price = 9.99f },
            new Book() { Title = "book3", Price = 12 },
            new Book() { Title = "book4", Price = 7 },
            new Book() { Title = "book5", Price = 9 },
        };
    }
}