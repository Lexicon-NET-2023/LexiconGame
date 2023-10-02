using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame.ConsoleGame.Entities
{
    public class Creature : IDrawable
    {
        private Cell cell = default!;
        private int health;
        private ConsoleColor color;
        public string Name => GetType().Name;
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
        public int Health 
        {
            get => health;
            set => health = value >= MaxHealth ? MaxHealth : value; 
        }
        public int MaxHealth { get;  }
        public bool IsDead => health <= 0;
        public int Damage { get; protected set; } = 50;
        public ConsoleColor Color 
        { 
            get => IsDead ? ConsoleColor.Gray : color;
            protected set => color = value;
        }
        public Action<string> AddToLog { get; set; } = default!;

        public Creature(Cell cell, string symbol, int maxHealth)
        {
            Cell = cell ?? throw new ArgumentNullException(nameof(cell));
            Symbol = symbol;
            MaxHealth = maxHealth;
            Health = maxHealth;
            color = ConsoleColor.Green;
        }

        public void Attack(Creature target)
        {
            if(target.IsDead || this.IsDead) return;

            var attacker = this.Name;

            target.Health -= Damage;

            AddToLog?.Invoke($"The {attacker} attacks the {target.Name} for {this.Damage}");

            if(target.IsDead)
                AddToLog?.Invoke($"The {target.Name} is dead");
        }

    }
}
