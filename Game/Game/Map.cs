namespace Game;
internal class Map
{
    public char[,] GameMap { get; private set; }

    public Map(string path, Player player)
    {
        var map = File.ReadAllLines(path);
        GameMap = new char[map[0].Length, map.Length];
        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[0].Length; ++j)
            {
                if (map[i][j] == '@')
                {
                    player.SetStartCords(j, i);
                    GameMap[j, i] = ' ';
                }
                else
                {
                    GameMap[j, i] = map[i][j];
                }
            }
        }
    }

    public void DisplayMap(Player player)
    {
        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                if (j == player.CordsOfPlayer.Item1 && i == player.CordsOfPlayer.Item2)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write(GameMap[j, i]);
                }
            }

            Console.WriteLine();
        }
    }

    public void DelatePlayer((int, int) cords)
    {
        Console.SetCursorPosition(0, Console.CursorTop - GameMap.GetLength(1) + cords.Item2);
        for (int i = cords.Item2; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                Console.Write(GameMap[j, i]);
            }

            Console.WriteLine();
        }
    }

    public void Update((int, int) cords)
    {
        Console.SetCursorPosition(0, Console.CursorTop - GameMap.GetLength(1) + cords.Item2);
        for (int i = cords.Item2; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                if (i == cords.Item2 && j == cords.Item1)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write(GameMap[j, i]);
                }
            }

            Console.WriteLine();
        }
    }
}
