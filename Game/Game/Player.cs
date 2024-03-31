namespace Game;

internal class Player
{
    public (int, int) CordsOfPlayer { get; private set; }

    public void SetStartCords(int cordX, int cordY)
    {
        CordsOfPlayer = (cordX, cordY);
    }

    public void MoveUp(Map map)
    {
        if (map.GameMap[CordsOfPlayer.Item1, CordsOfPlayer.Item2 - 1] != '*')
        {
            map.DelatePlayer(CordsOfPlayer);
            CordsOfPlayer = (CordsOfPlayer.Item1, CordsOfPlayer.Item2 - 1);
            map.Update(CordsOfPlayer);
        }
    }

    public void MoveDown(Map map)
    {
        if (map.GameMap[CordsOfPlayer.Item1, CordsOfPlayer.Item2 + 1] != '*')
        {
            map.DelatePlayer(CordsOfPlayer);
            CordsOfPlayer = (CordsOfPlayer.Item1, CordsOfPlayer.Item2 + 1);
            map.Update(CordsOfPlayer);
        }
    }

    public void MoveLeft(Map map)
    {
        if (map.GameMap[CordsOfPlayer.Item1 - 1, CordsOfPlayer.Item2] != '*')
        {
            map.DelatePlayer(CordsOfPlayer);
            CordsOfPlayer = (CordsOfPlayer.Item1 - 1, CordsOfPlayer.Item2);
            map.Update(CordsOfPlayer);
        }
    }

    public void MoveRight(Map map)
    {
        if (map.GameMap[CordsOfPlayer.Item1 + 1, CordsOfPlayer.Item2] != '*')
        {
            map.DelatePlayer(CordsOfPlayer);
            CordsOfPlayer = (CordsOfPlayer.Item1 + 1, CordsOfPlayer.Item2);
            map.Update(CordsOfPlayer);
        }
    }
}