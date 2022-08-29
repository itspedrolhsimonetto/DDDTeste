// See https://aka.ms/new-console-template for more information
using Domain;


Console.WriteLine("Hello, World!");


IPlayer player = new Player();
IPlayerProgress playerProgress = new PlayerProgress(player);
IPlayerBank playerBank = new PlayerBank(player);

