class Sample
{
    static void Main()
    {
        // area of circle
        int r = 3;
        float pi = 3.142F;
        float result = pi * r * r;
        System.Console.WriteLine("area of circle :{0}",result);


        // feet to centimeter 
        int feet = 5;
        int inches = 7;
        double centimeter = ((feet * 12) +inches ) * 2.54;
        System.Console.WriteLine("feet to centimeter:{0}", centimeter);

        // nearest thousand 
        int num = 2300;
        int no = num;
        int last3digit = no % 1000; 
        int roundedno = (num < 500) ? 1000 : 
                        (last3digit >= 500) ?   num + (1000 - last3digit) :
                        num - last3digit;

        System.Console.WriteLine(roundedno);


        //seconds to minutes 
        int seconds = 288970;
        int days = seconds / (24 * 60 * 60);
        int hours = (seconds % 86400) / (60 * 60);
        int minutes = ((seconds % 86400) % 3600) / 60;
        int remainingSec = (((seconds % 86400) % 3600) % 60);

        System.Console.WriteLine("{0} days , {1} hours ,{2} minutes, {3} seconds", days, hours, minutes, remainingSec);
        System.Console.ReadKey();




    }
}