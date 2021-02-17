using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superjump
{
    class MainPlayer
    {
        public List<Player> All;
        public Player player1;

        public Player ChosenPlayer => player1;
        public MainPlayer()
        {
            player1 = new Player("player1");
            All = new List<Player> 
            {
                player1,
            };
        }
        public void SpawnPlayer()
        {
            Form2.form.Controls.Add(ChosenPlayer);
        }
    }
}
