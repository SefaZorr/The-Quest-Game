using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Ghoul:Enemy,ISprite
    {
        public Ghoul(Game game, Point location, Size spriteSize) : base(game, location, 10, spriteSize) { }//10 can gönderdik Ghoul a.

        public override void Move(Random random)
        {
            if (random.Next(1, 3) != 1)// Ghoul 2/3 oranda player a dogru hareket eder 1/3 oranda yerinde sabit kalır.
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            if (NearPlayer())//Ghoul menzilin içindeyse 4 hit vurur.
            {
                game.HitPlayer(4, random);
            }
        }
    }
}
