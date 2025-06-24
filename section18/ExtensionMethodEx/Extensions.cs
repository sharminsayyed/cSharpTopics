using ClassLibrary1; // this is important to include the product class
using System;

namespace ExtensionMethodEx
{
    // step 2 - create a static class along with static method(extension) with the first parameter as this keyword 
    // static class that contains extension methods
    public static class Extensions
    {
        // extension method for product class (usge of this keyword ans classname name )
        // this method can be called by using instance of Product class 
        // this method acts as an instance method only 
        // when we use this this keyword along with the class name and it object the static method turns to be an instance method of that target class 
        public static double GetDiscount(this Product pro)
        {
            // here we cannot access the private members of the product class since we are outside the class 

            return pro.DiscountPer * pro.ProductCost / 100;
        }
    }
}
