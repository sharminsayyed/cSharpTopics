// derived class from Character
public class Warrior : Character
{
    // constructor for base class 
    public Warrior(string nm, int h, int a, int d) : base(nm, h, a, d)
    {
        // nothing here
    }

    //method
    public  void Charge(Character target)
    {
        int damage = attack*2  - target.defence;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"{name} charges {target.name} for {damage} damage");
        }
        else if(damage <= 0)
        {
            Console.WriteLine($"{name}'s charge has no effect on {target.name}.");
        }
    }

    // base class method overriden 
    public override void Defend()
    {
        defence += 5;
        Console.WriteLine($"{name} defends and gains 5 defense.");
    }


}