namespace bookOOPS
{
    class Books
    {
        public string title;
        public string author;
        public int price;
        public Books(string t, string a, int p)
        {
            title = t;
            author = a;
            price = p;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books=new Books("Idiots","Chetan",340);
            Console.WriteLine(books.title+" Written By "+books.author+". Its price is "+books.price);
            Books books1 = new Books("Liar", "Kishan", 500);
            Console.WriteLine(books1.title + " Written By " + books1.author + ". Its price is " + books1.price);
            Books books2 = new Books("Nam", "Karan", 450);
            Console.WriteLine(books2.title + " Written By " + books2.author + ". Its price is " + books2.price);
        }
    }
}
