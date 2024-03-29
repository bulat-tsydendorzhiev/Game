using Game;
var player = new Player();
var map = new Map("/home/sarapulov-vasilii/work/Game/Game/Game/map.txt", player);
map.DisplayMap(player);
player.MoveRight(map);
player.MoveUp(map);