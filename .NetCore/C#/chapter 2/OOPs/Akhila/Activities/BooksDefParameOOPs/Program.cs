namespace BooksDefParameOOPs
{
    class Books
    {
        public string title;
        public string author;
        public int price;
        public Books()
        {
            title = "Gitanjali";
            author = "Rabindranath tagore";
            price = 500;
        }
        public Books(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1=new Books();
            Console.WriteLine(book1.title + "\t" + book1.author + "\t" + book1.price);
            Books book2=new Books("The Guide","R.K.Narayanan",750);
            Console.WriteLine(book2.title + "\t" + book2.author + "\t\t" + book2.price);
        }
    }
}
