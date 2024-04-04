namespace Game;

/// <summary>
/// Class to work with objects of game map.
/// </summary>
public class Map
{
    /// <summary>
    /// Сoordinates where the player is initially located.
    /// </summary>
    public (int X, int Y) InitialPlayerCoordinates { get; private set; }

    /// <summary>
    /// Map where its objects located.
    /// </summary>
    public char[,] GameMap { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Map"/> class.
    /// </summary>
    /// <param name="filePath">File path.</param>
    public Map(string filePath)
    {
        var map = File.ReadAllLines(filePath);
        GameMap = new char[map[0].Length, map.Length];

        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[0].Length; ++j)
            {
                if (map[i][j] == '@')
                {
                    GameMap[j, i] = ' ';
                    InitialPlayerCoordinates = (j, i);
                }
                else
                {
                    GameMap[j, i] = map[i][j];
                }
            }
        }
    }

    /// <summary>
    /// Displays the map in the console.
    /// </summary>
    public void Display()
    {
        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                Console.Write((j, i) == InitialPlayerCoordinates ? '@' : GameMap[j, i]);
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Updates objects on the map.
    /// </summary>
    /// <param name="oldPlayerCoordinates">Old coordinates player locates.</param>
    /// <param name="newPlayerCoordinates">New coordinates player locates.</param>
    public void Update((int X, int Y) oldPlayerCoordinates, (int X, int Y) newPlayerCoordinates)
    {
        Console.SetCursorPosition(oldPlayerCoordinates.X, oldPlayerCoordinates.Y);
        Console.Write(' ');
        Console.SetCursorPosition(newPlayerCoordinates.X, newPlayerCoordinates.Y);
        Console.Write('@');
    }
}