using Game;
var player = new Player();
var map = new Map("map.txt", player);
map.DisplayMap(player);
player.MoveRight(map);
player.MoveUp(map);
