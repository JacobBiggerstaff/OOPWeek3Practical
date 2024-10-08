class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main(string[] args)
    {
        //Create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = " 123456677";

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1234566";

        //Output the book information to the console
        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");

        Console.WriteLine($"Book2 title: {book2.Title}");
        Console.WriteLine($"Book2 author: {book2.Author}");
        Console.WriteLine($"Book2 ISBN: {book2.ISBN}");

        //Output
    }
}
