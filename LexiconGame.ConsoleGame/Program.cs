﻿
//string someText = "Hej  på dig";

//foreach (var item in someText)
//{
//    Console.WriteLine(item);
//}



//var backpack = new LimitedList<string>(6);
//backpack.Add("Hej");


//foreach (var item in backpack)
//{
//    Console.WriteLine(item);
//}




var game = new Game(new ConsoleUI());
game.Run();

Console.WriteLine("Game Over");
Console.ReadLine();
