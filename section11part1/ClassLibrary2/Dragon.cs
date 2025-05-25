// derived class from Character

public class Dragon : Character
{
    // constructor 
    public Dragon(string nm, int h, int a, int d) : base(nm, h, a, d)
    {
        // nothing here 
    }

    // method
    public  void BreatheFire(Character target)
    {

        int damage = attack * 4 - target.defence;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"{name} breathes fire  on  {target.name} for {damage} damage");
        }
        else if (damage <= 0)
        {
            Console.WriteLine($"{name}'s fire  has no effect on {target.name}.");
        }
    }

    // overriden method from character class 
    public override void Attack(Character target)
    {
        int damage = attack*2 - target.defence;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"{name} attacks {target.name} for {damage} damage");
        }
        else if (damage <= 0)
        {
            Console.WriteLine($"{name}'s attack has no effect on {target.name}.");
        }
    }

    public override void Defend()
    {
        defence += 10;
        Console.WriteLine($"{name} defends and gains 10 defense.");
    }
}