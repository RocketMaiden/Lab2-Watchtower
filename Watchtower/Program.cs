Console.WriteLine("Please enter X coordinate of an enemy");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Y coordinate of an enemy");
int y = int.Parse(Console.ReadLine());

string response;
bool enemyPosition;

response = enemyPosition switch
{
    (x < 0 && y < 0) => "The enemy is to the SW",
    (x == 0 && y < 0) => "The enemy is to the S",
    (x > 0 && y < 0) => "The enemy is to the SE",
    (x < 0 && y == 0) => "The enemy is to the W",
    (x == 0 && y == 0) => "The enemy is here",
    (x > 0 && y == 0) => "The enemy is to the E",
    (x > 0 && y > 0) => "The enemy is to the NW",
    (x == 0 && y > 0) => "The enemy is to the N",
    (x > 0 && y > 0) => "The enemy is to the NE",
    _ => "Invalid data"
};

Console.WriteLine(response);
Console.ReadLine();
