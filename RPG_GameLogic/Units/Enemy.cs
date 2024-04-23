using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    internal class Enemy : IUnit
    {
        public string Name => "Enemy";

        public string Description => "Big guy with a weapon (SWORD)";

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
            Console.WriteLine($"Enemy takes {damage} damage!");

            if (CurrentHealth <= 0)
            { 
                Die();
            }
        }
    }
}
