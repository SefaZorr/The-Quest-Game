using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Mace:Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name
        {
            get
            {
                return "Mace";
            }
        }

        public override void Attack(Direction direction, Random random)//Yarı çapı 20 ve 8 hasar veriyor.Tam bir daire şeklinde saldırıyor.
        {
            if (!DamageEnemy(direction, 20, 8, random))
            {
                Direction nextAttackDirection = CounterClockWiseDirection(direction);
                for (int i = 0; i < 3; i++)
                {
                    if (DamageEnemy(nextAttackDirection, 20, 8, random))
                    {
                        break;
                    }
                    nextAttackDirection = CounterClockWiseDirection(direction);//Her yönü deniyor.
                }
            }
        }
    }
}
