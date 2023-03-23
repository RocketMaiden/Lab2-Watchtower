internal class Program
{
    private static void Main(string[] args)
    {
        (int, int) enemyPosition;

        Console.WriteLine("Please enter X coordinate of an enemy");
        enemyPosition.Item1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Y coordinate of an enemy");
        enemyPosition.Item2 = int.Parse(Console.ReadLine());

        string response;

        response = enemyPosition switch
        {
            ( < 0, < 0) => "The enemy is to the SW",
            (0, < 0) => "The enemy is to the S",
            ( > 0, < 0) => "The enemy is to the SE",
            ( < 0, 0) => "The enemy is to the W",
            (0, 0) => "The enemy is here",
            ( > 0, 0) => "The enemy is to the E",
            ( < 0, > 0) => "The enemy is to the NW",
            (0, > 0) => "The enemy is to the N",
            ( > 0, > 0) => "The enemy is to the NE"
        };

        Console.WriteLine(response);
        Console.ReadLine();
    }
}