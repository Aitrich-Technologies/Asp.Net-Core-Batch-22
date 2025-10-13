namespace BookActivity.Data
{
    public class BookService
    {
        List<Book> BookList=new List<Book>();
        public BookRepository bookRepo;
        public BookService(BookRepository bookRepository)
        {
            bookRepo=bookRepository;
        }

        public void AddNewBook(Book book)
        {
            bookRepo.AddNewBook(book);
        }
        public List<Book> GetAllBooks()
        {
            return bookRepo.GetAllBooks();
        }
    }
}
