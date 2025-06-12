public interface ILoanable
{
    int LoanPeriod { get; }
    string Borrower { get; set; }

    void Return();
    void Borrow(string borrower);
}