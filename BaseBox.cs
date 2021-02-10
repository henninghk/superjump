using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace superjump
{
    class BaseBox
    {
        public Color Color;
        public PictureBox Box;
        private string _name;
        public int Width { get; }
        public int Height { get; }
        public BaseBox(string name, int width, int height, Color color) 
        {
            Box = new PictureBox();
            Width = width;
            Height = height;
            _name = name;
            Color = color;
            Box.BackColor = Color;
            Box.Size = new Size(Width,Height);
        }

        
    }
}
