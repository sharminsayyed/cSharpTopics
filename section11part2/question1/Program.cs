class Program
{
    static void Main()
    {
        // using book class
        Book b1 = new Book 
        {
            Author = "Vijaya mam ",
            Title = "c++",
            ISBN = "9780747532743",
            Borrower = "sharmin"
        };

        b1.Print();
        b1.Return();

        Book b2 = new Book
        {
            Author = "Vijaya mam ",
            Title = "c++",
            ISBN = "9780747532743",
           
        };
        b2.Borrow("laxmi");
        Console.WriteLine();

        // using dvd class 
        DVD d1 = new DVD
        {
            Title = "office hours ",
            Director = "sajid khan ",
            LengthInMinutes = 345,
            Borrower = "priya"
        };
        d1.Print();
        d1.Return();

        DVD d2 = new DVD
        {
            Title = "office hours ",
            Director = "sajid khan ",
            LengthInMinutes = 345,
        };
        d2.Borrow("tanuja");
        Console.WriteLine();

        // using cd class 
        CD c1 = new CD
        {
            Artist = "arijit singh",
            Album = "Humsafar",
            NumberOfTracks = 12,
            Borrower = "pooja"
        };
        c1.Print();

        Console.ReadLine();
    }
}