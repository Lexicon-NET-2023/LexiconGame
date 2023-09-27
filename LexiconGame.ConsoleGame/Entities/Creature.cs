using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame.ConsoleGame.Entities
{
    internal class Creature : IDrawable
    {
        private Cell cell;
        public Cell Cell 
        {
            get => cell;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(cell));
                cell = value;
            }
        }
        public string Symbol { get; }
        public int Health { get; } = 100;
        public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;

        public Creature(Cell cell, string symbol)
        {
            Cell = cell;
            Symbol = symbol;
        }

    }
}
