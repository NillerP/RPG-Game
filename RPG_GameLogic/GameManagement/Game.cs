using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Items.Weapons;
using RPG_GameLogic.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.GameManagement
{
    public class Game
    {
        public Game()
        {
            Player player = new();
            Enemy enemy = new();
        }

        public void Start()
        {
            WeaponSelect();

            IUnit iunit = new Player();
            Console.WriteLine(iunit.Description);
            Console.ReadLine();
        }

        public static void WeaponSelect()
        {
            IWeapon swordStats = new Sword();
            IWeapon axeStats= new Axe();
            Console.WriteLine("What weapon will you be using? \n\n Sword \n Axe \n");
            Console.WriteLine(swordStats.Description+"\n"+axeStats.Description);
            Console.WriteLine("Critical hit will do double the amount of damage");
            string weaponSel = Console.ReadLine();
            Console.Clear();
            if (weaponSel.ToLower() == "sword")
            {
                Console.WriteLine("You chose Sword");
            }
            else
            {
                Console.WriteLine("You chose Axe");
            }


        }
    }
}
