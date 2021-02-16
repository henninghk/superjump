using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace superjump
{
    class Finishline
    {
        public List<Goal> All;
        public Goal complete;


        public Finishline()
        {
            complete = new Goal("Goal");
            All = new List<Goal>
            {
                 complete,
            };
        }
    }
}
