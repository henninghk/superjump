using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superjump
{
    class Enemy :  BaseBox
    {
        private int Speed;
        

        public Enemy(int speed, string name, int StartX, int StartY): base(name,39, 98, Color.Gold, StartX, StartY)
        {

            Speed = speed;

            
        }
        public void Move()
        {
            //if (Left >= (StartX + 15)) Speed = 0;
            //if (Right >= (StartX + 15)) Speed = 0;
            Left -= Speed;
           
        }

    }
}