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

    public Dictionary<(int X, int Y), int> Mobs { get; private set; } = new();

    /// <summary>
    /// Map where its objects located.
    /// </summary>
    public char[,] GameMap { get; private set; }

    private Rectangle[,] _gameMapRectangles;

    private int _size;

    private Pen _pen = new Pen(Color.Black, 2);

    /// <summary>
    /// Initializes a new instance of the <see cref="Map"/> class.
    /// </summary>
    /// <param name="filePath">File path.</param>
    public Map(string filePath, Panel drowPanel)
    {
        var map = File.ReadAllLines(filePath);
        GameMap = new char[map[0].Length, map.Length];
        _gameMapRectangles = new Rectangle[map[0].Length, map.Length];

        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[0].Length; ++j)
            {
                if (map[i][j] == '@')
                {
                    GameMap[j, i] = ' ';
                    CurrentPlayerCoordinates = (j, i);
                }
                else if (map[i][j] == '!')
                {
                    GameMap[j, i] = ' ';
                    Mobs[(j, i)] = 1;
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
    public void Display(Graphics g, Panel drowPanel)
    {
        if ((drowPanel.Width - drowPanel.Height) < (GameMap.GetLength(0) - GameMap.GetLength(1)) * _size)
        {
            _size = drowPanel.Width / GameMap.GetLength(0);
        }
        else 
        {
            _size = drowPanel.Height / GameMap.GetLength(1);
        }

        g.Clear(Color.White);

        for (int i = 0; i < GameMap.GetLength(1); ++i)
        {
            for (int j = 0; j < GameMap.GetLength(0); ++j)
            {
                var rect = new Rectangle(j * _size, i * _size, _size, _size);
                _gameMapRectangles[j, i] = rect;

                if (CurrentPlayerCoordinates.X == j && CurrentPlayerCoordinates.Y == i)
                {
                    g.FillRectangle(Brushes.Yellow, rect);
                    g.DrawRectangle(_pen, rect);
                }
                else if (GameMap[j, i] == ' ')
                {
                    if (Mobs.ContainsKey((j, i)))
                    {
                        g.FillRectangle(Brushes.Red, rect);
                    }
                    g.DrawRectangle(_pen, rect);
                }
                else
                {
                    g.FillRectangle(Brushes.Blue, rect);
                    g.DrawRectangle(_pen, rect);
                }
            }
        }
    }

    /// <summary>
    /// Method <c>Update</c> updates objects on the map.
    /// </summary>
    /// <param name="oldPlayerCoordinates">Old coordinates player locates.</param>
    /// <param name="newPlayerCoordinates">New coordinates player locates.</param>
    /// <returns>Damage player will get if player on the mob's coordinates; otherwise false.</returns>
    public int Update((int X, int Y) newPlayerCoordinates, Graphics g)
    {
        int damageValue = 0;
        if (Mobs.ContainsKey(newPlayerCoordinates))
        {
            damageValue = Mobs[newPlayerCoordinates];
            Mobs.Remove(newPlayerCoordinates);
        }

        g.FillRectangle(Brushes.White, _gameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);
        g.DrawRectangle(_pen, _gameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);

        CurrentPlayerCoordinates = newPlayerCoordinates;

        g.FillRectangle(Brushes.Yellow, _gameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);
        g.DrawRectangle(_pen, _gameMapRectangles[CurrentPlayerCoordinates.X, CurrentPlayerCoordinates.Y]);

        return damageValue;
    }
}