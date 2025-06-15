
namespace WareHouese
{
    public partial class Product
    {
        //private field and property 
        private int _pid;
        public int Pid { set; get; }

        // decalration of partial method in one file
        // partial method by default private
        partial void GetTax();
    }
}
