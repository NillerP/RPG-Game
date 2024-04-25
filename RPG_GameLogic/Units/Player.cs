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
        private IWeapon equippedWeapon;

        public string Name => "Rudolf";

        public string Description => "Rudolf lived as a simple farmer after being sold by a desperate relative to settle a debt. With no training or experience, everyone thought he will meet his demise quickly in the arena.";

        public int MaxHealth => 50;

        public int CurrentHealth { get; set; } = 50;

        public void EquipWeapon(IWeapon weapon)
        {
            equippedWeapon = weapon;
        }

        public void Attack(IUnit enemy)
        {
            if (equippedWeapon == null)
            {
                Console.WriteLine("No weapon equipped!");
                return;
            }

      
            equippedWeapon.Attack(enemy);
        }


        public void Die()
        {
            Console.Clear();
            Console.WriteLine("Rudolf was Defeated : YOU LOST");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            Console.WriteLine($"Rudolf takes {damage} damage!\n\nRudolf overall health is : {CurrentHealth}");

            if (CurrentHealth <= 0)
            {
                Die();
            }
        }
    }
}
