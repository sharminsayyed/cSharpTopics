public class Book:ILoanable, IPrintable
{
    // properties
    public string Author { get; set; }
    public string Title { get; set; }
    public string ISBN{ get; set; }

    public int LoanPeriod { get { return 21; } } //loanable for 21 days.
    public string Borrower { get; set; }

    //methods from both interface 

    //defines the method Print, which should print out information about the item.
    public void Print()
    {
        Console.WriteLine($"{Title} wriiten by {Author} (ISBN = {ISBN}) ");
    }

    public void Borrow(string borrower)
    {
        if(Borrower == null)
        {
            Borrower = borrower;
            Console.WriteLine($"{Title} wriiten by {Author} is now borrowed by {Borrower}");
        }
        else
        {
            Console.WriteLine($"{Title} wriiten by {Author}was already borrowed by {Borrower}");

        }
    }

    public void Return()
    {
        if(Borrower == null)
        {
            Console.WriteLine($"{Title} wriiten by {Author} was not borrowed ");
        }
        else
        {
            Console.WriteLine($"{Title} wriiten by {Author} was returned by {Borrower}");
        }
    }
}