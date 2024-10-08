class Book
{
    //properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    //constructor for book object
    public Book(string bookTitle, string bookAuthor , string bookISPN, int bookNoOfPages)
    {
        Title = bookTitle;  
        Author = bookAuthor;
        ISBN = bookISPN;
        NoOfPages = bookNoOfPages;

    }


    void DisplayInfo()
    {
        //Output the book information to the console
        Console.WriteLine($"Book Information");
        Console.WriteLine($"----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"No of pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create a new instance of the book class
        Book book = new Book("C# for beginners", "Bill Gates", "123456", 200);

        // Output book information to the console



        book.DisplayInfo();
     

        //Output
    }
}
