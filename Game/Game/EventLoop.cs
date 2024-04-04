namespace Game;

/// <summary>
/// Checks that the player has moved.
/// </summary>
public class EventLoop
{
    /// <summary>
    /// Checks that the player has moved left.
    /// </summary>
    public event EventHandler<EventArgs> LeftHandler = (sender, args) => {};

    /// <summary>
    /// Checks that the player has moved right.
    /// </summary>
    public event EventHandler<EventArgs> RightHandler = (sender, args) => {};

    /// <summary>
    /// Checks that the player has moved up.
    /// </summary>
    public event EventHandler<EventArgs> UpHandler = (sender, args) => {};

    /// <summary>
    /// Checks that the player has moved down.
    /// </summary>
    public event EventHandler<EventArgs> DownHandler = (sender, args) => {};

    /// <summary>
    /// Reads user actions.
    /// </summary>
    public void Run()
    {
        while (true)
        {
            var key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    LeftHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.RightArrow:
                    RightHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.UpArrow:
                    UpHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.DownArrow:
                    DownHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.CursorVisible = true;
                    return;
            }
        }
    }
}