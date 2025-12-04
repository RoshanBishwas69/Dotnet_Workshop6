namespace Workshop6
{
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }
    }
}