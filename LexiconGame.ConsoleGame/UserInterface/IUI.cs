﻿namespace LexiconGame.ConsoleGame.UserInterface
{
    public interface IUI
    {
        void AddMessage(string message);
        void Clear();
        void Draw(Map map);
        ConsoleKey GetKey();
        void PrintLog();
        void PrintStats(string stats);
    }
}