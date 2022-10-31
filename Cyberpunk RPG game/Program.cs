using Cyberpunk_RPG_game;
using Cyberpunk_RPG_game.Locations;

var player = new Player(PubDesert.PubWelcome());
player.ShowMenuStats();
player.TestNewWeapon();
player.ShowMenuStats();
Console.Clear();
player.StreetRepLvl = 3;
CorpoPlaza.Location(player); 