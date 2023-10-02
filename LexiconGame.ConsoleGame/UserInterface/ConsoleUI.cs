﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame.ConsoleGame.UserInterface
{
    public class ConsoleUI
    {
        private static MessageLog<string> messageLog = new(6);

        public void AddMessage(string message) => messageLog.Add(message);
        //{
        //    messageLog.Add(message);
        //}

        public void PrintLog()
        {
            messageLog.Print(m => Console.WriteLine(m + new string(' ', Console.WindowWidth - m.Length)));
            //messageLog.Print(Console.WriteLine);
        }

        public  void Clear()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }

        public  ConsoleKey GetKey() => Console.ReadKey(intercept: true).Key;


        public  void Draw(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell? cell = map.GetCell(y, x);
                    ArgumentNullException.ThrowIfNull(cell, nameof(cell));
                    IDrawable drawable = cell;

                    drawable = map.Creatures.CreatureAtExtension2(cell) ?? cell.Items.FirstOrDefault() as IDrawable ?? cell;
                   
                    Console.ForegroundColor = drawable.Color;
                    Console.Write(drawable.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintStats(string stats)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(stats);
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
