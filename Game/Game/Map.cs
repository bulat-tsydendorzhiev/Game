internal class Map
{
    public (int, int) CordsOfPlayer { get; set; }

    public char[,] GameMap { get; private set; }

    public Map(string path)
    {
        var map = File.ReadAllLines(path);
        GameMap = new char[map[0].Length, map.Length];
        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[0].Length; ++j)
            {
                GameMap[j, i] = map[i][j];
            }
        }
    }

    public void DisplayMap()
    {
        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                Console.Write(GameMap[j, i]);
            }

            Console.WriteLine();
        }
    }
}