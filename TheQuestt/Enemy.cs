using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public abstract class Enemy:Mover, ISprite  //Abstract tanımlandı Enemy den direk nesne oluşturamayız kalıtım için kullanıcaz.
    {
        private const int NearPlayerDistance = 25;  //Enemy nin playere hasar vurma uzaklıgı.
        private int hitpoints;

        public int HitPoints { get { return hitpoints; } }

        public Size SpriteSize { get; private set; }

        public bool Dead//Enemy nin ölüp ölmedigini kontrol ediyor ona göre dungeonda visibilie ayarlıyoruz.
        {
            get
            {
                if (hitpoints <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Enemy(Game game, Point location, int hitPoints, Size spriteSize) : base(game, location)
        {
            this.hitpoints = hitPoints;
            SpriteSize = spriteSize;
        }

        public abstract void Move(Random random);//Abstract sınıf içinde abstract metot tanımladık bundan tureyen her sınıf bu metodu yazmak zorunda.

        public void Hit(int maxDamage, Random random)//Player Attack() metodunu çagırdıgında enemy Hit() methodu çagrılır.
        {
            hitpoints = hitpoints - random.Next(1, maxDamage);
        }

        protected bool NearPlayer()//Protected tanımladık sadece enemy sınıfından tureyenler kullanabilecek.Oyuncunun menzili içinde (yakınında) olup olmadıgını kontrol ediyor.
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected Direction FindPlayerDirection(Point playerLocation)//Game tanmlanan oyuncunun location'ı buraya işlenir.Playerin yönünü bulup onu yakalamaya çalışıyor.Düşmana hangi yönde hareeket etmesi gerektigini söylüyor.
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
            {
                directionToMove = Direction.Right;
            }
            else if (playerLocation.X < location.X - 10)
            {
                directionToMove = Direction.Left;
            }
            else if (playerLocation.Y < location.Y - 10)
            {
                directionToMove = Direction.Up;
            }
            else
            {
                directionToMove = Direction.Down;
            }

            return directionToMove;
        }
    }
}
