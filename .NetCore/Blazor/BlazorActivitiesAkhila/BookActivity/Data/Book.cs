namespace BookActivity.Data
{
    public class Book
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Book() { }
        public Book(string name,string description,int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
