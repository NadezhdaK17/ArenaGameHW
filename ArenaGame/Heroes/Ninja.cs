using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Ninja:Hero
    {
        private double hitCount;
        private double damageCoef;

        public Ninja(string name, double armor,double strenght, IWeapon  weapon):base(name,armor, strenght, weapon) 
        { 
            hitCount = 1;
            damageCoef = 0.3;
        }

        public override double Attack()
        {
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                damage *= 3;
            }
            return damage;
        }



    }
}
