// derived class from character
public class Mage : Character
{
    // constructor 
    public Mage(string nm, int h, int a, int d) : base(nm, h, a, d)
    {
        // nothing here 
    }
    // method 
    public void CastSpell(Character target)
    {
        int damage = attack * 3 - target.defence;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"{name} casts a spell on  {target.name} for {damage} damage");
        }
        else if (damage <= 0)
        {
            Console.WriteLine($"{name}'s spell  has no effect on {target.name}.");
        }
    }

    // override the mehod and seal the method which cannot be overriden 
    public sealed override void Defend()
    {
        Console.WriteLine($"{name} cannot defend!");
    }
}