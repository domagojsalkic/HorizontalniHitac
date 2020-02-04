using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorizontalniHitac.Objects
{
    class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; set; }

        public Ball()
        {
            X = 0;
            Y = 0;
            Radius = 30;
        }

        public void Move(float dX, float dY)
        {
            X += dX;
            Y += dY;
        }

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Orange, 2), X, Y, Radius * 2, Radius * 2);
            g.FillEllipse(new System.Drawing.SolidBrush(System.Drawing.Color.Orange), X, Y, Radius * 2, Radius * 2);
        }
    }
}
