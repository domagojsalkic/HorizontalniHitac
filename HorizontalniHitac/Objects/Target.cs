using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorizontalniHitac.Objects
{
    class Target
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public Target() { }
        public Target(int x, int y)
        {
            Width = 120;
            Height = 10;
            Random rand = new Random();
            X = rand.Next(x / 3, x - (int)Width);
            Y = y - (int)Height*2;
        }

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Black, 1), X, Y, Width, Height);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), X, Y, Width, Height);
        }
    }
}
