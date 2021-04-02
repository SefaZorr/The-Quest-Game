using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public abstract class Mover  //Abstract tanımlandı Mover dan direk nesne oluşturamayız kalıtım için kullanıcaz.
    {
        private const int MoveInterval = 10;//Hareket etmenin aralıgını belirtiyor 10-10 artıyor.
        protected Point location;

        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)//Bir nokta alır ve nesneden belirli bir uzaklıkta olup olmadıgını anlar.
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction direction, Rectangle boundaires)//Alandan çıkmadıgı zaman burdaki sonuca göre hareket eder.
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaires.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;

                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaires.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaires.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaires.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;

                default:
                    break;
            }
            return newLocation;
        }
    }
}
