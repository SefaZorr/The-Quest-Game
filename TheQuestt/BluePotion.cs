﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class BluePotion:Weapon,IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public bool Used { get; private set; }

        public override string Name
        {
            get
            {
                return "Blue Potion";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!Used)
            {
                game.IncreasePlayerHealth(5, random);
                Used = true;
            }
        }
    }
}
