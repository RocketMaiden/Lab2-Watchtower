(int, int) enemyPosition;
bool enemyAlert = false;

Console.WriteLine("Please enter X coordinate of an enemy");
enemyPosition.Item1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Y coordinate of an enemy");
enemyPosition.Item2 = int.Parse(Console.ReadLine());

string response;

response = enemyAlert switch
{
    (enemyPosition.Item1 < 0 && enemyPosition.Item2 < 0) => "The enemy is to the SW",
    (enemyPosition.Item1 == 0 && enemyPosition.Item2 < 0) => "The enemy is to the S",
    (enemyPosition.Item1 > 0 && enemyPosition.Item2 < 0) => "The enemy is to the SE",
    (enemyPosition.Item1 < 0 && enemyPosition.Item2 == 0) => "The enemy is to the W",
    (enemyPosition.Item1 == 0 && enemyPosition.Item2 == 0) => "The enemy is here",
    (enemyPosition.Item1 > 0 && enemyPosition.Item2 == 0) => "The enemy is to the E",
    (enemyPosition.Item1 > 0 && enemyPosition.Item2 > 0) => "The enemy is to the NW",
    (enemyPosition.Item1 == 0 && enemyPosition.Item2 > 0) => "The enemy is to the N",
    (enemyPosition.Item1 > 0 && enemyPosition.Item2 > 0) => "The enemy is to the NE",
    _ => "Invalid data"
};

Console.WriteLine(response);
Console.ReadLine();
