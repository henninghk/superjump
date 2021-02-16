using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superjump
{
    class Coin : BaseBox
    {
        public Coin(string name, int StartX, int StartY) : base(name, 37, 36, Color.Goldenrod, StartX, StartY)
        {

        }
    }
}
