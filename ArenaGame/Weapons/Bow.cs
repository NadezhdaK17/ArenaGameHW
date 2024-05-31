using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    //лък
    public class Bow : IWeapon
    {
        public string Name { get; set; }    
        public double AttackDamage {  get; set; }    
        public  double BlockingPower { get; set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }
    }
}
