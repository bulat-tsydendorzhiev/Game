namespace Game;

/// <summary>
/// Player on the map.
/// </summary>
public class Player
{
    /// <summary>
    /// Current player coordinates.
    /// </summary>
    public (int, int) CurrentCoordinates { get; private set; }

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
    /// <param name="coordinateByX">Coordinate by X.</param>
    /// <param name="coordinateByY">Coordinate by Y.</param>
    /// <param name="map">Game map.</param>
    public Player(int coordinateByX, int coordinateByY, Map gameMap)
    {
        CurrentCoordinates = (coordinateByX, coordinateByY);
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

        map.Reset();
        CurrentCoordinates = (newCoordinateByX, newCoordinateByY);
        map.Update(CurrentCoordinates);
    }

    private bool IsValidCoordinates(int coordinateByX, int coordinateByY) => coordinateByX >= 0 && coordinateByX < map.GameMap.GetLength(0)
                                                                        && coordinateByY >= 0 && coordinateByY < map.GameMap.GetLength(1);

    private bool IsReachableCoordinates(int coordinateByX, int coordinateByY) => !"-|".Contains(map.GameMap[coordinateByX, coordinateByY]);

    private (int, int) GetNewCoordinates(Direction direction)
    => direction switch
    {
        Direction.Left => (CurrentCoordinates.Item1 - 1, CurrentCoordinates.Item2),
        Direction.Right => (CurrentCoordinates.Item1 + 1, CurrentCoordinates.Item2),
        Direction.Up => (CurrentCoordinates.Item1, CurrentCoordinates.Item2 - 1),
        Direction.Down => (CurrentCoordinates.Item1, CurrentCoordinates.Item2 + 1),
    };
}