namespace Game.Tests;

public class Tests
{
    [Test]
    public void TestMovePlayer()
    {
        var map = new Map("../../../testFiles/mapForTestMovePlayer.txt");
        var player = new Player(map);
        player.MakeMove(Player.Direction.Left);
        Assert.That((map.InitialPlayerCoordinates.X - 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Right);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Up);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y - 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Down);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsLeft()
    {
        var map = new Map("../../../testFiles/mapForTestMoveOutOfBounds.txt");
        var player = new Player(map);
        player.MakeMove(Player.Direction.Left);
        Assert.That((map.InitialPlayerCoordinates.X - 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Left);
        Assert.That((map.InitialPlayerCoordinates.X - 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsRight()
    {
        var map = new Map("../../../testFiles/mapForTestMoveOutOfBounds.txt");
        var player = new Player(map);
        player.MakeMove(Player.Direction.Right);
        Assert.That((map.InitialPlayerCoordinates.X + 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Right);
        Assert.That((map.InitialPlayerCoordinates.X + 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsUp()
    {
        var map = new Map("../../../testFiles/mapForTestMoveOutOfBounds.txt");
        var player = new Player(map);
        player.MakeMove(Player.Direction.Up);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y - 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Up);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y - 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsDown()
    {
        var map = new Map("../../../testFiles/mapForTestMoveOutOfBounds.txt");
        var player = new Player(map);
        player.MakeMove(Player.Direction.Down);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y + 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Down);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y + 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveThroughWalls()
    {
        var map = new Map("../../../testFiles/mapForTestMoveThroughWalls.txt");
        var player = new Player(map);
        player.MakeMove(Player.Direction.Left);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Right);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Up);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MakeMove(Player.Direction.Down);
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }
}