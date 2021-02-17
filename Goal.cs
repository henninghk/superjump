using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superjump
{
    class Goal : BaseBox
    {
        public bool HasPlayerWon;
        public Goal() : base("FinishLine", 39, 98, Color.Peru, 33, 33)
        {
            
        }
    }
}
