using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Ghost:Enemy,ISprite
    {
        public Ghost(Game game, Point location, Size spriteSize) : base(game, location, 8, spriteSize) { }//8 can gönderdik ghost a.

        public override void Move(Random random)
        {
            if (random.Next(1, 3) == 1) //Ghost 1/3 oranda player a dogru hareket eder 2/3 oranda yerinde sabit kalır.
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            if (NearPlayer())//Ghost menzilin içindeyse 3 hit vurur. 
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
