using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Bow:Weapon
    {
        public Bow(Game game, Point location) : base(game, location) { }

        public override string Name
        {
            get
            {
                return "Bow";
            }
        }

        public override void Attack(Direction direction, Random random)//Yarı çapı 30 ve 3 hasar vuruyor tek yönde saldırıyor.
        {
            DamageEnemy(direction, 30, 3, random);
        }
    }
}
