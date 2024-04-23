using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Items.Weapons
{
    
    internal class Axe : IWeapon
    {
        private static Random random = new Random();
        private int axeDmg;

        public int damage {get; set;}

        public void Attack(IUnit target)
        {
            damage = random.Next(1,5);
            damage += AxeCrit();
            target.TakeDamage(damage);
        }
        public int AxeCrit()
        {
            double critChance = 0.2;
            double randValue = random.NextDouble();
            if (randValue < critChance)
            {
                return damage * 2;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
