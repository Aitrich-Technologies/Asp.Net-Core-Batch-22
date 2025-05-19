namespace BooksdisplayOOPs
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
        public void display()
        {
            
            Console.WriteLine(this.title + " written by " + this.author + ". Its price is " + this.price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books("Idiots", "Chetan", 340);
            books.display();
            Books books1 = new Books("Liar", "Kishan", 500);
            books1.display();
            Books books2 = new Books("Nam", "Karan", 450);
            books2.display();
        }
    }
}
