// base class 
public class Character
{
    // properties
    public string name { set; get; }
    public int health { set; get; }
    public int attack { set; get; }
    public int defence { set; get; }
    //constructor 
    public Character(string nm, int h, int a, int d)
    {
        name = nm;
        health = h;
        attack = a;
        defence = d;
    }

    // method overriding
    public virtual void Attack(Character target)
    {
        int damage = attack - target.defence;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"{name} attacks {target.name} for {damage} damage");
        }
        else if(damage <= 0)
        {
            Console.WriteLine($"{name}'s attack has no effect on {target.name}.");
        }
    }

    public virtual void Defend()
    {
        Console.WriteLine($"{name} defends.");
    }

}