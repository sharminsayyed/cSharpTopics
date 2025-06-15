namespace WareHouese
{
    public partial class Product
    {
        // partial method should be implemented in another file
        partial void GetTax()
        {
            double tax = Cost * 10 / 100;
            Console.WriteLine(tax);
        }
    }
}