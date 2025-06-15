namespace WareHouese
{
    public partial class Product
    {
        //private feild and property
        private double _cost;
        public double Cost { set; get; }
        

        // here we create a public method to call the partial method inside it 
        public void CallPartialMethod()
        {
            this.GetTax();
        }
    }
}