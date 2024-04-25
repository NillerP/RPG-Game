using RPG_GameLogic.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Interfaces
{
    internal interface IUnit
    {
        string Name { get; }
        string Description { get; }
        int MaxHealth { get; }
        int CurrentHealth {  get; set;}
        void Move();
        void TakeDamage(int damage);
        void Attack(IUnit enemy);
        void Die();
    }
}
