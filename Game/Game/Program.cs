var eventLoop = new EventLoop();
var game = new Game();
eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;

eventLoop.Run();
