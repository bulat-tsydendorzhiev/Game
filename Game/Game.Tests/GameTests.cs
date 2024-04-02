namespace Game.Tests;

public class Tests
{
    [Test]
    public void TestMovePlayer()
    {
        var map = new Map("../../../testFiles/map3.txt");
        var player = new Player(map);
        player.MoveLeft();
        Assert.That((map.InitialPlayerCoordinates.X - 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveRight();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveUp();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y - 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveDown();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsLeft()
    {
        var map = new Map("../../../testFiles/map2.txt");
        var player = new Player(map);
        player.MoveLeft();
        Assert.That((map.InitialPlayerCoordinates.X - 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveLeft();
        Assert.That((map.InitialPlayerCoordinates.X - 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsRight()
    {
        var map = new Map("../../../testFiles/map2.txt");
        var player = new Player(map);
        player.MoveRight();
        Assert.That((map.InitialPlayerCoordinates.X + 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveRight();
        Assert.That((map.InitialPlayerCoordinates.X + 1, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsUp()
    {
        var map = new Map("../../../testFiles/map2.txt");
        var player = new Player(map);
        player.MoveUp();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y - 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveUp();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y - 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveOutOfBoundsDown()
    {
        var map = new Map("../../../testFiles/map2.txt");
        var player = new Player(map);
        player.MoveDown();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y + 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveDown();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y + 1),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }

    [Test]
    public void TestMoveThroughWalls()
    {
        var map = new Map("../../../testFiles/map1.txt");
        var player = new Player(map);
        player.MoveLeft();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveRight();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveUp();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
        player.MoveDown();
        Assert.That((map.InitialPlayerCoordinates.X, map.InitialPlayerCoordinates.Y),
            Is.EqualTo((player.CurrentCoordinates.X, player.CurrentCoordinates.Y)));
    }
}