using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Interfaces
{
    internal interface IWeapon
    {
        void Attack(IUnit target);

        float Damage {get; set;}

        float CritChance{get;}

        float CritMultiplier{get;}

        string Description{get;}
    }

}
