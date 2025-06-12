public class CD : IPrintable, ILoanable
{
    // properties
    public string Artist { get; set; }
    public string Album { get; set; }
    public int NumberOfTracks { get; set; }

    public int LoanPeriod { get { return 14; } }  // loanable for 14 days.
    public string Borrower { get; set; }

    // methods 

    public void Print()
    {
        Console.WriteLine($"{Album} by {Artist} " +
            $"({ (Borrower == null ? "availaible" :"borrowed by "+Borrower )})" +
            $"");
    }

    public void Borrow(string borrower)
    {
        Borrower = borrower;
        Console.WriteLine($"{Album} by {Artist} has been borrowed by {Borrower}");

    }

    public void Return()
    {
        Console.WriteLine($"{Album} by {Artist} has been returned ");
        Borrower = null;
    }
}