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
        public MainPlayer mainplayer;
        public Enemies enemies;
        public Leveles levels;
        public Coins coins;
        public Goal goal;
        public Form2()
        {
            mainplayer = new MainPlayer();
            enemies = new Enemies();
            levels = new Leveles();
            coins = new Coins();
            goal = new Goal();
            ClientSize = new Size(675,628);
            form = this;
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            levels.SpawnLeveles();
            mainplayer.SpawnPlayer();
            SpawnEnemies();
            SpawnCoins();
            SpawnGoal();
            form.Text = "Hei, jeg heter Henning!";
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
        public void SpawnGoal()
        {
            Controls.Add(goal);
        }
    }
}
