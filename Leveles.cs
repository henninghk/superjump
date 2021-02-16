using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superjump
{
    class Leveles
    {
        public List<Level> All;
        public Level level1;
        public Level level2;
        public Level level3;
        public Level level4;
        public Level level5;
        public Level level6;
        public Level level7;
        public Level level8;
        public Level level9;
        public Level level10;
        public Level level11;
        public Level level12;





        public Leveles()
        {
            
            level1 = new Level("levelOne", 272, 45,  -9, 570);
            level2 = new Level("levelTwo", 194, 15, 305, 510);
            level3 = new Level("levelThree", 140, 20, 143, 405);
            level4 = new Level("levelFour", 188, 22,  370, 305);
            level5 = new Level("levelFive", 115, 10,  143, 226);
            level6 = new Level("levelSix", 77, 16, 181, 528);
            level7 = new Level("levelSeven", 65, 13, 56, 176);
            level8 = new Level("levelEight", 65, 13, 33, 376);
            level9 = new Level("levelNine", 65, 13,  281, 334);
            level10 = new Level("levelTen", 65, 13,  305, 226);
            level11 = new Level("levelEleven", 65, 13, 538, 457);
            level12 = new Level("levelTwelve", 65, 13,  589, 376);


            All = new List<Level>
            {
                level1,
                level2,
                level3,
                level4,
                level5,
                level6,
                level7,
                level8,
                level9,
                level10,
                level11,
                level12,
            };
        }
    }
}