using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superjump
{
    class Coins
    {
        public List<Coin> All;
        public Coin point1;
        public Coin point2;
        public Coin point3;
        public Coin point4;
        public Coins()
        {
            point1 = new Coin("pointOne", 325, 119);
            point2 = new Coin("pointTwo", 71, 291);
            point3 = new Coin("pointThree", 346, 376);
            point4 = new Coin("pointFour", 617, 305);
            All = new List<Coin>
            {
                 point1,
                 point2,
                 point3,
                 point4,
            };
        }
    }
}
