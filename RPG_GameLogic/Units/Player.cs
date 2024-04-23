using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    internal class Player : IUnit
    {
        public string Name => "Main Character";

        public string Description => "Have plot armor, cannot die";

        public int MaxHealth => 50;

        public int CurrentHealth {get; set;} = 50;

        public void Attack(int damage)
        {
            Console.WriteLine($"Enemy attacks for {damage} damage!");
        }

        public void Die()
        {
            Console.WriteLine("Enemy Defeated");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            Console.WriteLine($"Player takes {damage} damage!");

            if (CurrentHealth <= 0)
            { 
                Die();
            }
        }
    }
}
