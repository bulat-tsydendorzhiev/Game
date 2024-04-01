namespace Game;

/// <summary>
/// Class to work with objects of game map.
/// </summary>
public class Map
{
    /// <summary>
    /// Сoordinates where the player is initially located.
    /// </summary>
    public (int, int) InitialPlayerCoordinates { get; private set; }

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
    /// Reset map.
    /// </summary>
    public void Reset()
    {
        Console.SetCursorPosition(0, 0);

        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                Console.WriteLine();
            }
        }
    }

    /// <summary>
    /// Update objects on map.
    /// </summary>
    /// <param name="newPlayerCoordinates">New coordinates player locates.</param>
    public void Update((int, int) newPlayerCoordinates)
    {
        Console.SetCursorPosition(0, 0);

        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                Console.Write((j, i) == newPlayerCoordinates ? '@' : GameMap[j, i]);
            }

            Console.WriteLine();
        }
    }
}