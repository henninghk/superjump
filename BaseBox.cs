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
        public int StartX { get; }
        public int StartY { get; }
        //public bool IsVisible => Box.Visible;
        public BaseBox(string name, int width, int height, Color color, int startX, int startY) 
        {
            Box = new PictureBox();
            Width = width;
            Height = height;
            _name = name;
            Color = color;
            StartX = startX;
            StartY = startY;
            Box.BackColor = Color;
            Box.Size = new Size(Width,Height);
            Box.Location = new Point(StartX, StartY);
        }
        //public void ChoseVisibility(bool isVisible)
        //{
        //    Box.Visible = isVisible;
        //}
        public void SpawnBox()
        {
            Form2.form.Controls.Add(Box);
        }
        //public void RemoveBox()
        //{
        //    Form2.form.Controls.Remove(Box);
        //}

        
    }
}
