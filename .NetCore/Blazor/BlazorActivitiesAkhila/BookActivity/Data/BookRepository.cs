namespace BookActivity.Data
{
    public class BookRepository
    {
        List<Book> booksList=new List<Book>();
        public void AddNewBook(Book book)
        {
                booksList.Add(book);
           
        }
        public List<Book> GetAllBooks()
        {
            return booksList;
        }
    }
}
