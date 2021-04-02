using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuestt
{
    public class Game
    {
        public List<Enemy> Enemies;//Oyundaki düşmanları tutar.
        public Weapon WeaponInRoom;//Odadaki silahları tutar.

        private Player player;//Oyuncumuzu oluşturup game clasına baglanmımızı saglar.

        public Point PlayerLocation { get { return player.Location; } }//Oyuncunun konumu.
        public int PlayerHitPoints { get { return player.HitPoints; } }

        public Size PlayerSpriteSize { get { return player.SpriteSize; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }//Silah isimlerinin listesini tutar.

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;//Oyundaki hareket edilebilecek alanı tutar.Rectangle classından nesne oluşturduk.
        public Rectangle Boundaries { get { return boundaries; } }

        public Panel panel2;
        public Game(Rectangle boundaries, Panel panel2)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70), new Size(30, 30));//Oyuncunun ilk konumunu atıyor.
            this.panel2 = panel2;
        }

        public void Move(Direction direction, Random random)//Move methodu buradan sınıflara gönderilir.Önce mesela Player sınıfına gider oradan mover sınıfına gider ordan return edilir.
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    enemy.Move(random);
                }
            }
        }

        public void Equip(string weaponName)//Envanterdeki herhangi bir skile tıklandınıgında çalışır ve player sınıfına yönlendirir.
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)//Envanterde silahın olup olmadıgının kontrolu.
        {
            return player.Weapons.Contains(weaponName);
        }

        public bool CheckPotionUsed(string potionName)//Envanterdeki iksiri kullanıp kullanmadıgını gösterir.
        {
            return player.CheckPotionUsed(potionName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)//Saldırı sistemini oluşturur.
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    enemy.Move(random);
                }
            }
        }

        private Point GetRandomLocation(Random random)//Random konum atmaya yarıyor.
        {
            return new Point(boundaries.Left +
                random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NexLewel(Random random)//Leveller arası geçişi ve iksir,düşman ekliyor ona göre.
        {
            level++;
            switch (level)
            {
                case 0:
                    MessageBox.Show("You Win!","The Quest Game");
                    Application.Exit();
                    break;

                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    panel2.BackColor = Color.Red;
                    break;

                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    panel2.BackColor = Color.Blue;
                    break;

                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    panel2.BackColor = Color.OrangeRed;
                    break;

                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    panel2.BackColor = Color.Yellow;
                    WeaponInRoom = null;
                    if (!CheckPlayerInventory("Bow"))
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    break;

                case 5:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    panel2.BackColor = Color.Crimson;
                    break;
                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    panel2.BackColor = Color.Aqua;
                    break;

                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    panel2.BackColor = Color.Salmon;
                    WeaponInRoom = null;
                    if (!CheckPlayerInventory("Mace"))
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    level = -1;
                    break;

            }
        }
    }
}
