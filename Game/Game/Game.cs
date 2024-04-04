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

    /// <summary>
    /// Change the player's position on the map to the left.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="args">Argument.</param>
    public void MoveLeft(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Left), player.CurrentCoordinates);
    }

    /// <summary>
    /// Change the player's position on the map to the right.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="args">Argument.</param>
    public void MoveRight(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Right), player.CurrentCoordinates);
    }

    /// <summary>
    /// Change the player's position on the map to the up.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="args">Argument.</param>
    public void MoveUp(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Up), player.CurrentCoordinates);
    }

     /// <summary>
    /// Change the player's position on the map to the down.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="args">Argument.</param>
    public void MoveDown(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Down), player.CurrentCoordinates);
    }
}