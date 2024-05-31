using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    //vending machines=автомати
    public class VendingMachines:IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; set; }
        public double BlockingPower { get; set; }

        public VendingMachines(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }
    }
}
