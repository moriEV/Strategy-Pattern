using Strategy_Pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player(new Sword(), "Pasha");
        Game game = new Game(player);
        while (true)
        {
            game.Start();
            Console.ReadLine();
        }
    }
}
