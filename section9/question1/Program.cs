/*
 Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.

The Pin should be exactly 4 digits or 6 digits.

If the supplied pin is invalid, it shows error message.



Examples:

Pin = "1234"     -->  valid

Pin = "1234ef"     -->  invalid

Pin = "123456"     -->  valid

Pin = "0"     -->  invalid

Pin = "a4"     -->  invalid*/
class DebitCard
{
    private string _pin;
    public string Pin
    {
        set
        {
            if(value != null && value != "")
            {
                if(value.Length == 4 || value. Length == 6)
                {
                    bool valid = true;
                    for(int i =0; i< value.Length;i++)
                    {
                        //ASCII codes 48 to 57 are equal to digits (0 to 9)
                        // if the ele in string is other than digits then it will be false 
                        if (value[i] < 48 || value[i] > 57)
                            valid = false; // then it is not a digit 

                    }

                    if(valid == true)
                    {
                        _pin = value;
                    }
                    else
                    {
                        Console.WriteLine("pin conatins one or more non-digit characters ");
                    }
                }
                else
                {
                    Console.WriteLine("pin should be of 4 or 6 digits number ");
                }
            }
            else
            {
                Console.WriteLine("pin cannot be null or empty");
            }
        }
        get { return _pin; }
    }
}

class Program
{
    static void Main()
    {
        DebitCard d = new DebitCard();
        d.Pin = "012345";
        Console.WriteLine(d.Pin);

        Console.ReadKey();
    }
}