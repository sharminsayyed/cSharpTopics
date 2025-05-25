// main method is here 
public class Program
{
    static void Main()
    {
        // create charcters 
        Warrior c1 = new Warrior("sharmin", 100, 20, 10);
        Mage c2 = new Mage("laxmi", 80, 15, 5);
        Dragon c3 = new Dragon("pooja", 200, 30, 20);

        //test character method 
        c1.Attack(c2);
        c2.Defend();
        c3.BreatheFire(c1);
        c3.Defend();
        c1.Defend();

        //game between characters 
        Game game = new Game();
        game.Battle(c1, c2);
        game.Battle(c1, c3);
        game.Battle(c2, c3);

        Console.ReadKey();



            

    }
}