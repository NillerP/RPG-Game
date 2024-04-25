using RPG_GameLogic.Factories;
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
            
        }
        static Player player = new();
        static Enemy enemy = new();
        public async Task Start()
        {
           WeaponSelect();
           HeroInfo();
           EnemyInfo();
           Fight();
           Console.ReadLine();
        }

        public void WeaponSelect()
        {
            Sword swords = new Sword();
            Axe axes = new Axe();
            bool weaponSelected = false;
            while (!weaponSelected)
            {
                
                Console.WriteLine("What weapon will you be using? \n\n Sword \n Axe \n");
                Console.WriteLine($"Sword: {swords.Description}" + $"\n\nAxe: {axes.Description}\n");
                Console.WriteLine("Critical hit will do double the amount of damage");
                
                string weaponSel = Console.ReadLine();
                Console.Clear();

                if (weaponSel.ToLower().Contains("sword"))
                {
                    IWeapon sword = WeaponFactory.CreateWeapon("sword");
                    Console.WriteLine($"You chose Sword\n\n{sword.Description}\n");
                    player.EquipWeapon(sword);
                    weaponSelected = true;
                }
                else if (weaponSel.ToLower().Contains("axe"))
                {
                    IWeapon axe = WeaponFactory.CreateWeapon("axe");
                    Console.WriteLine($"You chose Axe\n\n{axe.Description}\n");
                    player.EquipWeapon(axe);
                    weaponSelected = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose Sword or Axe.");
                }
            }

            Console.ReadLine();
            Console.Clear();
        }

        public static void HeroInfo()
        {
            IUnit player = new Player();
            Console.WriteLine($"Your Character will be: {player.Name}\n");
            Console.WriteLine($"Backstory: {player.Description}");
            Console.ReadLine();
            Console.Clear();
        }
        public static void EnemyInfo()
        {
            IUnit enemy = new Enemy();
            Console.WriteLine($"Your First opponent is: {enemy.Name}\n");
            Console.WriteLine("Weapon axe\n\n");
            Console.WriteLine($"Backstory: {enemy.Description}");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Fight()
        {
            Console.WriteLine($"{player.Name} vs {enemy.Name}");
            Console.WriteLine("You strike first");
            Console.ReadLine();
            bool fight = true;
            while (fight == true)
            {
                if (fight)
                {
                    Console.Clear();
                    Console.WriteLine("\n(You) Rudolf Strikes at Quandale\n");
                    player.Attack(enemy);
                    Console.WriteLine("\n");
                    Console.WriteLine("Quandale Strikes at (You) Rudolf\n");
                    enemy.Attack(player);
                    Console.WriteLine();
                    Console.ReadLine();
                    if(player.CurrentHealth <= 0 || enemy.CurrentHealth <= 0)
                    {
                        Console.ReadLine();
                        break;
                    }
                }
            }
            Console.ReadLine();
            Console.Clear();




        }

    }
}

