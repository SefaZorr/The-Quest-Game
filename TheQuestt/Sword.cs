using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Sword:Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override void Attack(Direction direction, Random random)//Yarıçapı 10 ve 5 puan hasar verir 3 yönde saldırıyor.
        {
            if (!DamageEnemy(direction, 10, 5, random))
            {
                if (!DamageEnemy(ClockwiseDirection(direction), 10, 5, random))
                {
                    DamageEnemy(CounterClockWiseDirection(direction), 10, 5, random);
                }
            }
        }
    }
}
