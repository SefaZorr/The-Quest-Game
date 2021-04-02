using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestt
{
    public class Player:Mover,ISprite
    {
        private Weapon equippedWeapon;//Şuan kullanılan weapon.
        private int hitPoints;

        public int HitPoints { get { return hitPoints; } }
        public Size SpriteSize { get; private set; }//Oyuncu her eklendiginde belli bir boyutta ekeleniyor.

        private List<Weapon> inventory = new List<Weapon>();//Oyunda kazandıgın silahları tutar.

        public List<string> Weapons//Birden fazla silah olabilir envanterde ama bir tanesini alıp kullanabilir.Envanterin isimlerinden liste çıkartıyor.
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Player(Game game, Point location, Size spriteSize) : base(game, location)
        {
            hitPoints = 35;//Player 35 can veriyor.
            SpriteSize = spriteSize;
        }

        public void Hit(int maxDamage, Random random)//Enemy den aldıgı hasar ile canı azaltılır.
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)//Iksir içtitignde oyunucunun canını random olarak arttırır.
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)//Envanterdeki picture lara tıklayınca çalışır eger envanterdeyse giyilir.
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Move(Direction direction)//Kalıtım olarak aldıgımız mover sınıfına gönderim yaparak ve ekrandaki weapon ları almamızı burası saglar.
        {
            base.location = Move(direction, game.Boundaries);//Buradaki Move() mover sınıfına baglanır.
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 10))//Silahın yada iksirin alınıp alınmayacagını kontrol eder.10 ise silahları felan alma aralıgı.
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
            }
        }

        public void Attack(Direction direction, Random random)//Playerin saldırı methodu.Eger silah varsa bizde Weapon ın Attack() methoduna gidiyoruz.
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
            }
        }

        public bool CheckPotionUsed(string potionName)
        {
            IPotion potion;
            bool potionUsed = true;

            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == potionName && weapon is IPotion)
                {
                    potion = weapon as IPotion;//Yani potionu weapon olarak al diyor.
                    potionUsed = potion.Used;
                }
            }
            return potionUsed;
        }
    }
}
