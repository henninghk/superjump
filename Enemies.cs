﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            enemy1 = new Enemy("enemyOne",   427, 406);
            enemy2 = new Enemy("enemyTwo",   504, 201);
            enemy3 = new Enemy("enemyThree",   224, 57);
            enemy4 = new Enemy("enemyFour",   181, 305);
            All = new List<Enemy>
            {
                enemy1,
                enemy2,
                enemy3,
                enemy4,
            };
        }
    }
}
