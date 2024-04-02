namespace Game;

public class Game
{
    private Map map;

    private Player player;

    /// <summary>
    /// Initializes a new instance of the <see cref="Game"/> class.
    /// </summary>
    /// <param name="filePath">File path.</param>
    public Game(string filePath)
    {
        Console.Clear();
        Console.CursorVisible = false;
        map = new Map(filePath);
        player = new Player(map);
        map.Display();
    }

    public void MoveLeft(object sender, EventArgs args)
    {
        player.MoveLeft();
    }

    public void MoveRight(object sender, EventArgs args)
    {
        player.MoveRight();
    }

    public void MoveUp(object sender, EventArgs args)
    {
        player.MoveUp();
    }

    public void MoveDown(object sender, EventArgs args)
    {
        player.MoveDown();
    }
}