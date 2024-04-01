namespace Game;

/// <summary>
/// Object player on the game map.
/// </summary>
public class Player
{
    /// <summary>
    /// Current player coordinates.
    /// </summary>
    public (int X, int Y) CurrentCoordinates { get; private set; }

    /// <summary>
    /// Map where player moves.
    /// </summary>
    private Map map;

    /// <summary>
    /// Direction player move.
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Left direction.
        /// </summary>
        Left,

        /// <summary>
        /// Right direction.
        /// </summary>
        Right,

        /// <summary>
        /// Up direction.
        /// </summary>
        Up,

        /// <summary>
        /// Down direction.
        /// </summary>
        Down,
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="map">Game map.</param>
    public Player((int, int) playerCoordinates, Map gameMap)
    {
        CurrentCoordinates = playerCoordinates;
        map = gameMap;
    }

    /// <summary>
    /// Makes player go on left direction.
    /// </summary>
    public void MoveLeft()
    {
        MakeMove(Direction.Left);
    }

    /// <summary>
    /// Makes player go on right direction.
    /// </summary>
    public void MoveRight()
    {
        MakeMove(Direction.Right);
    }

    /// <summary>
    /// Makes player go on up direction.
    /// </summary>
    public void MoveUp()
    {
        MakeMove(Direction.Up);
    }

    /// <summary>
    /// Makes player go on down direction.
    /// </summary>
    public void MoveDown()
    {
        MakeMove(Direction.Down);
    }

    private void MakeMove(Direction direction)
    {
        (int newCoordinateByX, int newCoordinateByY) = GetNewCoordinates(direction);

        if (!IsValidCoordinates(newCoordinateByX, newCoordinateByY))
        {
            return;
        }

        if (!IsReachableCoordinates(newCoordinateByX, newCoordinateByY))
        {
            return;
        }

        map.Update(CurrentCoordinates, (newCoordinateByX, newCoordinateByY));
        CurrentCoordinates = (newCoordinateByX, newCoordinateByY);
    }

    private bool IsValidCoordinates(int coordinateByX, int coordinateByY) => coordinateByX >= 0 && coordinateByX < map.GameMap.GetLength(0)
                                                                            && coordinateByY >= 0 && coordinateByY < map.GameMap.GetLength(1);

    private bool IsReachableCoordinates(int coordinateByX, int coordinateByY) => !"-|".Contains(map.GameMap[coordinateByX, coordinateByY]);

    private (int, int) GetNewCoordinates(Direction direction)
    => direction switch
    {
        Direction.Left => (CurrentCoordinates.X - 1, CurrentCoordinates.Y),
        Direction.Right => (CurrentCoordinates.X + 1, CurrentCoordinates.Y),
        Direction.Up => (CurrentCoordinates.X, CurrentCoordinates.Y - 1),
        Direction.Down => (CurrentCoordinates.X, CurrentCoordinates.Y + 1),
    };
}