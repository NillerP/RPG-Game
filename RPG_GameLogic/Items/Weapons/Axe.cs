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
        public float Damage{get; set;}

        public float CritChance => 0.2f;
        public float CritMultiplier => 2.0f;

        public string Description => "Axe: Will deal between 1 to 5 hitpoints and have 20% chance of getting a Critical Hit";

        public void Attack(IUnit target)
        {
            Damage = random.Next(1,5);
            Damage += WeaponUtility.Crit(Damage, CritChance, CritMultiplier);
            target.TakeDamage((int)Damage);
        }
    }
}
