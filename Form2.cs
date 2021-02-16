using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace superjump
{
    class Form2 : Form
    {
        
        public static Form2 form;

        public Enemies enemies;
        public Leveles levels;
        public Coins coins;
        public Finishline goal;
        public Form2()
        {
            enemies = new Enemies();
            levels = new Leveles();
            coins = new Coins();
            goal = new Finishline();
            ClientSize = new Size(675,628);
            form = this;
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            SpawnLeveles();
            SpawnEnemies();
            SpawnCoins();
            SpawnFinishline();
            form.Text = "Hei, jeg heter Henning!";
        }
        public void SpawnLeveles()
        {
            foreach (var Level in levels.All)
            {
                Controls.Add(Level);
            }
        }
        public void SpawnEnemies()
        {
            foreach (var enemy in enemies.All)
            {
                Controls.Add(enemy);
            }
        }
        public void SpawnCoins()
        {
            foreach (var coin in coins.All)
            {
                Controls.Add(coin);
            }
        }
        public void SpawnFinishline()
        {
            foreach (var Goal in goal.All)
            {
                Controls.Add(Goal);
            }
        }
    }
}
