namespace Game;

/// <summary>
/// Class <c>Player</c> works with object player on the game map.
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
    public Player(Map gameMap)
    {
        CurrentCoordinates = gameMap.InitialPlayerCoordinates;
        map = gameMap;
    }

    /// <summary>
    /// Method <c>MakeMove</c> implements the player's movement on the map.
    /// </summary>
    /// <param name="direction">Direction of movement.</param>
    /// <returns>The coordinates of the player before the move.</returns>
    public (int oldCoordinateByX, int oldCoordinateByY) MakeMove(Direction direction)
    {
        (int newCoordinateByX, int newCoordinateByY) = GetNewCoordinates(direction);

        if (!IsValidCoordinates(newCoordinateByX, newCoordinateByY))
        {
            return (CurrentCoordinates.X, CurrentCoordinates.Y);
        }

        if (!IsReachableCoordinates(newCoordinateByX, newCoordinateByY))
        {
            return (CurrentCoordinates.X, CurrentCoordinates.Y);
        }

        var oldCoordinates = CurrentCoordinates;
        CurrentCoordinates = (newCoordinateByX, newCoordinateByY);
        return oldCoordinates;
    }

    /// <summary>
    /// Method <c>IsValidCoordinates</c> checks that the player can exist in the given coordinates.
    /// </summary>
    /// <param name="coordinateByX">Player's x-axis coordinate.</param>
    /// <param name="coordinateByY">Player's y-axis coordinate.</param>
    /// <returns>true if it's possible, otherwise a false.</returns>
    private bool IsValidCoordinates(int coordinateByX, int coordinateByY) => coordinateByX >= 0 && coordinateByX < map.GameMap.GetLength(0)
                                                                            && coordinateByY >= 0 && coordinateByY < map.GameMap.GetLength(1);

    /// <summary>
    /// Method <c>IsReachableCoordinates</c> checks that there are no walls in the direction of movement.
    /// </summary>
    /// <param name="coordinateByX">Player's x-axis coordinate.</param>
    /// <param name="coordinateByY">Player's y-axis coordinate.</param>
    /// <returns>false if there is, otherwise true.</returns>
    private bool IsReachableCoordinates(int coordinateByX, int coordinateByY) => !"-|".Contains(map.GameMap[coordinateByX, coordinateByY]);

    /// <summary>
    /// Method <c>GetNewCoordinates</c> returns the new coordinates of the player, takes into account the direction of his movement.
    /// </summary>
    /// <param name="direction">Direction of movement.</param>
    /// <returns>Gets coordinates of the new position player.</returns>
    private (int, int) GetNewCoordinates(Direction direction)
    => direction switch
    {
        Direction.Left => (CurrentCoordinates.X - 1, CurrentCoordinates.Y),
        Direction.Right => (CurrentCoordinates.X + 1, CurrentCoordinates.Y),
        Direction.Up => (CurrentCoordinates.X, CurrentCoordinates.Y - 1),
        Direction.Down => (CurrentCoordinates.X, CurrentCoordinates.Y + 1),
    };
}