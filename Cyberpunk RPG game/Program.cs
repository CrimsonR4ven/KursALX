﻿using Cyberpunk_RPG_game;
using Cyberpunk_RPG_game.Items;
using Cyberpunk_RPG_game.Locations;

var player = new Player(PubDesert.PubWelcome());
player.ShowMenuStats();
player.TestNewWeapon();
player.AddRepPoints(501);
player.ShowMenuStats();
CorpoPlaza.Location(player);

Cybernetic Test = new Cybernetic(CyberneticsList.GetRavenFullBody());
Console.WriteLine(Test.FullName);