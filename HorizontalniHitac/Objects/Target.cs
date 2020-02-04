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
        public float Radius { get; set; }

        public Target() { }
        public Target(int x, int y)
        {
            Radius = 60;
            Random rand = new Random();
            X = rand.Next(x / 3, x - (int)Radius*2);
            Y = y - (int) Radius;
        }

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black, 4), X, Y, Radius * 2, Radius / 2);
        }
    }
}
