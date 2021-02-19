using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superjump
{
    class Enemies
    {

        public List<Enemy> All;
        public Enemy enemy1;
        public Enemy enemy2;
        public Enemy enemy3;
        public Enemy enemy4;
        public Enemies()
        {
            
            enemy1 = new Enemy(5,"enemyOne",   427, 406);
            enemy2 = new Enemy(3,"enemyTwo",   504, 201);
            enemy3 = new Enemy(13,"enemyThree",   224, 57);
            enemy4 = new Enemy(1,"enemyFour",   181, 305);
            All = new List<Enemy>
            {
                enemy1,
                enemy2,
                enemy3,
                enemy4,
            };
        }
        public void MoveAll()
        {
            foreach (var enemy in All)
            {
                enemy.Move();
            }
        }
        //public Label SeeSpeedAndLeftAndStartX()
        //{
        //    Label label = new Label();
        //    label.Size = new Size(200, 200);
        //    label.Text = "Left:" + enemy1.Left.ToString();
        //    label.Text += $"\tWidth: {enemy1.Width}";
        //    label.Text += $"\tStartX: {enemy1.StartX}";
        //    return label;

        //}
    }
}
