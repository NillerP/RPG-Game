using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_GameLogic.Items.Weapons;

namespace RPG_GameLogic.Factories
{
    internal class WeaponFactory
    {
        public static IWeapon CreateWeapon(string weaponType)
        {
            switch (weaponType.ToLower())
            {
                case "sword":
                    return new Sword();
                case "axe":
                    return new Axe();
                // Add more cases for other weapon types...
                default:
                    throw new ArgumentException("Invalid weapon type");
            }
        }
    }
}
