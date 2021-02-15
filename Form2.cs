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
        public Form2()
        {
            enemies = new Enemies();
            levels = new Leveles();
            ClientSize = new Size(675,628);
            form = this;
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            SpawnLeveles();
            SpawnEnemies();
            form.Text = "Hei, jeg heter Henning!";
        }
        public void SpawnLeveles()
        {
            foreach (var Level in levels.All)
           {
                Level.SpawnBox();
            }
        }
        public void SpawnEnemies()
        {
            foreach (var enemy in enemies.All)
            {
                enemy.SpawnBox();
            }
            //foreach (var enemy in enemies.All)
            //{
            //    enemy.RemoveBox();
            //}
        }
    }
}
