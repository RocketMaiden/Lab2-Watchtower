internal class Program
{
    private static void Main(string[] args)
    {
        (int, int) towerPosition;
        (int, int) enemyPosition;
        (int, int) enemyRelativePosition;
        string response;

        Console.WriteLine("Enter watchtower position. It should stay in range from -5 to 5");

        Console.WriteLine("Enter watchtower X");
        
        while (true)
        {
            towerPosition.Item1 = ReadUserInput("not a digit - please, enter a digit");
            if (towerPosition.Item1 <= 5 && towerPosition.Item1 >= - 5)
            {
                Console.WriteLine($"Your tower coordinate X is {towerPosition.Item1}");
                break;
            }
            else
            {
                Console.WriteLine("Coordinate is not in the range from -5 to 5");
            }
        }
        
        Console.WriteLine("Enter watchtower Y");

        while (true)
        {
            towerPosition.Item2 = ReadUserInput("not a digit - please, enter a digit");
            if (towerPosition.Item2 <= 5 && towerPosition.Item2 >= - 5)
            {
                Console.WriteLine($"Your tower coordinate Y is {towerPosition.Item2}");
                break;
            }
            else
            {
                Console.WriteLine("Coordinate is not in the range from -5 to 5");
            }
        }

        enemyPosition = SetEnemyPosition();
        enemyRelativePosition = GetEnemyRelativePosition(enemyPosition, towerPosition);

        response = enemyRelativePosition switch
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

    static int ReadUserInput(string exceptionMessage)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine(exceptionMessage);
            }
        }
    }

    static (int, int) SetEnemyPosition()
    {
        int randomX = new Random().Next(-5, 6);
        int randomY = new Random().Next(-5, 6);
        
        return(randomX, randomY);
    }

    static (int, int) GetEnemyRelativePosition((int, int) enemyPosition, (int, int) towerPosition)
    {
        int relativeEnemyX = towerPosition.Item1 - enemyPosition.Item1;
        int relativeEnemyY = towerPosition.Item2 - enemyPosition.Item2;
        
        return (relativeEnemyX, relativeEnemyY);
    }
}