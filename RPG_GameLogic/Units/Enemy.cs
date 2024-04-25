using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    internal class Enemy : IUnit
    {
        public string Name => "Quandale";

        public string Description => "\nQuandale was raised and forced to steal on the street to survive after being abandom from his parents. He soon got caught stealing from a rich man and got two choices either lose his head or the Gladiator pits.";

        public int MaxHealth => 50;

        public int CurrentHealth {get; set;} = 50;
        Player player =new Player();

        public void Attack(IUnit enemy)
        {
            Axe axe = new Axe();
            axe.Attack(player);
        }

        public void Die()
        {
            Console.Clear();
            Console.WriteLine("Quandale was Defeated : YOU WON");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            Console.WriteLine($"Quandale takes {damage} damage!\n\nQuandales overall health is : {CurrentHealth}");

            if (CurrentHealth <= 0)
            { 
                Die();
            }
        }
    }
}
