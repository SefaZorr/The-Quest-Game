using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    interface ISprite//Canavarların boyutlarını tutar hitbox u tutar.
    {
        Size SpriteSize { get; }
    }
}
