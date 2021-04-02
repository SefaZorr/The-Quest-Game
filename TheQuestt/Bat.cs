using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Bat:Enemy
    {
        public Bat(Game game, Point location, Size spriteSize) : base(game, location, 6, spriteSize) { }//6 can gönderdik burdan Bat e.

        public override void Move(Random random)//Move methounda %50 şansı oluyor ya player a dogru hareket edecek yada random bir yöne hareket edecek.
        {
            if (random.Next(1, 2) == 1)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else
            {
                location = Move((Direction)random.Next(1, 4), game.Boundaries);
            }
            if (NearPlayer())//Bat menzilin içindeyse oyuncuya 2 hit vurur.
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
