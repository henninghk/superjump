using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superjump
{
    class Level : BaseBox
    {


        public Level(string name, int width, int height, Color color, int StartX, int StartY) : base(name, width, height, color, StartX, StartY)
        {

        }
    }
}
