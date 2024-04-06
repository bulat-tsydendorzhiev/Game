using System.Drawing;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace GameGUI;

/// <summary>
/// Class <c>Map</c> to work with objects of game map.
/// </summary>
public class Map
{
    /// <summary>
    /// Сoordinates where the player is initially located.
    /// </summary>
    public (int X, int Y) CurrentPlayerCoordinates { get; private set; }

    /// <summary>
    /// Map where its objects located.
    /// </summary>
    public char[,] GameMap { get; private set; }
    private Rectangle[,] GameMapRectangles;

    private int size = 50;
    private Graphics graphics;
    private Pen pen = new Pen(Color.Black, 2);
    /// <summary>
    /// Initializes a new instance of the <see cref="Map"/> class.
    /// </summary>
    /// <param name="filePath">File path.</param>
    public Map(string filePath)
    {
        var map = File.ReadAllLines(filePath);
        GameMap = new char[map[0].Length, map.Length];
        GameMapRectangles = new Rectangle[map[0].Length, map.Length];
        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[0].Length; ++j)
            {
                if (map[i][j] == '@')
                {
                    GameMap[j, i] = ' ';
                    CurrentPlayerCoordinates = (j, i);
                }
                else
                {
                    GameMap[j, i] = map[i][j];
                }
            }
        }
    }

    /// <summary>
    /// Method <c>Display</c> displays the map in the console.
    /// </summary>
    public void Display(PaintEventArgs e)
    {
        //graphics = 
        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                
                var rect = new Rectangle(j * size, i * size, size, size);
                GameMapRectangles[j, i] = rect;
                if (CurrentPlayerCoordinates.X == j && CurrentPlayerCoordinates.Y == i)
                {
                    e.Graphics.FillRectangle(Brushes.Green, rect);
                    e.Graphics.DrawRectangle(pen, rect);
                }
                else if (GameMap[j, i] == ' ')
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Blue, rect);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
    }

    /// <summary>
    /// Method <c>Update</c> updates objects on the map.
    /// </summary>
    /// <param name="oldPlayerCoordinates">Old coordinates player locates.</param>
    /// <param name="newPlayerCoordinates">New coordinates player locates.</param>
    public void Update((int X, int Y) newPlayerCoordinates, Graphics g)
    {
        g.FillRectangle(Brushes.White, GameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);
        g.DrawRectangle(pen, GameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);
        CurrentPlayerCoordinates = newPlayerCoordinates;
        g.FillRectangle(Brushes.Green, GameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);
        g.DrawRectangle(pen, GameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);
    }
}