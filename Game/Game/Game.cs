namespace Game;

/// <summary>
/// Class <c>Game</c> initializes game and change the player's position on the map.
/// </summary>
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
    /// Method <c>MoveLeft</c> change the player's position on the map to the left.
    /// </summary>
    /// <param name="sender">Event, player moves to the left.</param>
    /// <param name="args">Data this event.</param>
    public void MoveLeft(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Left), player.CurrentCoordinates);
    }

    /// <summary>
    /// Method <c>MoveRight</c> change the player's position on the map to the right.
    /// </summary>
    /// <param name="sender">Event, player moves to the right.</param>
    /// <param name="args">Data this event.</param>
    public void MoveRight(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Right), player.CurrentCoordinates);
    }

    /// <summary>
    /// Method <c>MoveUp</c> change the player's position on the map to the up.
    /// </summary>
    /// <param name="sender">Event, player moves to the up.</param>
    /// <param name="args">Data this event.</param>
    public void MoveUp(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Up), player.CurrentCoordinates);
    }

    /// <summary>
    /// Method <c>MoveDown</c> change the player's position on the map to the down.
    /// </summary>
    /// <param name="sender">Event, player moves to the down.</param>
    /// <param name="args">Data this event.</param>
    public void MoveDown(object sender, EventArgs args)
    {
        map.Update(player.MakeMove(Player.Direction.Down), player.CurrentCoordinates);
    }
}