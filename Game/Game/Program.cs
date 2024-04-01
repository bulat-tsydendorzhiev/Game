using Game;

if (args.Length != 1)
{
    Console.WriteLine("Invalid input parameters. Enter -h to learn more information.");
    return;
}

if (args[0] == "-help")
{
    string message = """
                    "Dog walking" game.
                    To start game enter path with map in txt format.
                    How to move: Use arrows on tour keyboard, their direction will
                    make player to move on the same direction.
                    If you want to leave: press escape button to left the game
                    """;
    Console.WriteLine(message);
    return;
}

if (!File.Exists(args[0]))
{
    Console.WriteLine("Wrong file path.");
    return;
}

var eventLoop = new EventLoop();

var game = new Game.Game(args[0]);

eventLoop.LeftHandler += game.MoveLeft;
eventLoop.RightHandler += game.MoveRight;
eventLoop.UpHandler += game.MoveUp;
eventLoop.DownHandler += game.MoveDown;

eventLoop.Run();
