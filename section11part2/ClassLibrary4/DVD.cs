public class DVD : ILoanable, IPrintable
{
    // properties
    public string Director { get; set; }
    public string Title { get; set; }
    public int LengthInMinutes { get; set; }

    public int LoanPeriod { get { return 7; } }  // loanable for 7 days.
    public string Borrower { get; set; }

    //methods from both interface 

    //defines the method Print, which should print out information about the item.
    public void Print()
    {
        Console.WriteLine($"{Title} directed by {Director} ({LengthInMinutes} min) ");
    }

    public void Borrow(string borrower)
    {
        if (Borrower == null)
        {
            Borrower = borrower;
            Console.WriteLine($"{Title} directed by {Director} is now borrowed by {Borrower}");
        }
        else
        {
            Console.WriteLine($"{Title} directed by {Director}was already borrowed by {Borrower}");

        }
    }

    public void Return()
    {
        if (Borrower == null)
        {
            Console.WriteLine($"{Title} director by {Director} was not borrowed ");
        }
        else
        {
            Console.WriteLine($"{Title} director by {Director} was returned by {Borrower}");
        }
    }
}