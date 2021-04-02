using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public abstract class Weapon:Mover
    {
        private bool pickedUp;//Seçilen silahı gösteriyor.

        public bool PickedUp { get { return pickedUp; } }

        public Weapon(Game game, Point location) : base(game, location)
        {
            pickedUp = false;
        }

        public void PickUpWeapon()//Silah alınırsa pickedUp true yapıyor
        {
            pickedUp = true;
        }

        public abstract string Name { get; }//Abstract sınıfta abstract prop var diger sınıflarda zorunlu bunları yazmak.Her silahın bir ismi olucak.

        public abstract void Attack(Direction direction, Random random);//Abstract sınıfta abstract metot var diger sınıflarda zorunlu bunu yazmak.Her silahın nasıl saldırı yapacagını belli edicez.


        private bool Nearby(Point playerLocation, Enemy enemy, Direction direction, int distance)//Silahın menzilinde düşman varmı ona bakıcaz.
        {
            bool isNearby = false;
            Rectangle enemySpriteBoundary = new Rectangle(enemy.Location, enemy.SpriteSize);
            Rectangle playerAttackArea = new Rectangle();

            switch (direction)
            {
                case Direction.Up:
                    playerAttackArea.Location = new Point(playerLocation.X, playerLocation.Y - distance);
                    playerAttackArea.Width = game.PlayerSpriteSize.Width;
                    playerAttackArea.Height = distance;
                    break;

                case Direction.Right:
                    playerAttackArea.Location = new Point(playerLocation.X + game.PlayerSpriteSize.Width, playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = game.PlayerSpriteSize.Height;
                    break;

                case Direction.Down:
                    playerAttackArea.Location = new Point(playerLocation.X, playerLocation.Y + game.PlayerSpriteSize.Height);
                    playerAttackArea.Width = game.PlayerSpriteSize.Width;
                    playerAttackArea.Height = distance;
                    break;

                case Direction.Left:
                    playerAttackArea.Location = new Point(playerLocation.X + distance, playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = game.PlayerSpriteSize.Height;
                    break;
            }

            if (playerAttackArea.IntersectsWith(enemySpriteBoundary))
            {
                isNearby = true;
            }

            return isNearby;
        }

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)//Önce düşmanı arıyor bulursa.enemy.hit çagırıyor.Yani hasar vurma metodu.
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation, enemy, direction, radius))
                {
                    enemy.Hit(damage, random);
                    return true;
                }
            }
            return false;
        }

        protected Direction ClockwiseDirection(Direction direction)//Attack yönlerini tutuyor.
        {
            Direction clockWiseDirection = direction;

            switch (direction)
            {
                case Direction.Up:
                    clockWiseDirection = Direction.Right;
                    break;

                case Direction.Right:
                    clockWiseDirection = Direction.Down;
                    break;

                case Direction.Down:
                    clockWiseDirection = Direction.Left;
                    break;

                case Direction.Left:
                    clockWiseDirection = Direction.Up;
                    break;

            }
            return clockWiseDirection;
        }

        protected Direction CounterClockWiseDirection(Direction direction)//Attack yonlerini tutuyor.
        {
            Direction counterClockWiseDirection = direction;

            switch (direction)
            {
                case Direction.Up:
                    counterClockWiseDirection = Direction.Left;
                    break;
                case Direction.Right:
                    counterClockWiseDirection = Direction.Up;
                    break;
                case Direction.Down:
                    counterClockWiseDirection = Direction.Right;
                    break;
                case Direction.Left:
                    counterClockWiseDirection = Direction.Down;
                    break;
            }

            return counterClockWiseDirection;
        }
    }
}
