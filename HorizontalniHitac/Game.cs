using HorizontalniHitac.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorizontalniHitac
{
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        Ball ball;
        Target target;
        int hitCounter = 0, shotCounter = 0;
        double velocity;

        private void Game_Load(object sender, EventArgs e)
        {
            ball = new Ball();
            target = new Target(panel.ClientRectangle.Width, panel.ClientRectangle.Height);
            hitCount.Text = hitCounter.ToString();
            shotCount.Text = shotCounter.ToString();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ball.Draw(e.Graphics);
            target.Draw(e.Graphics);
        }

        private void powerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(powerTextBox.Text, out velocity))
            {
                fireButton.Enabled = true;
            }
            else
            {
                fireButton.Enabled = false;
            }
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
                shotCount.Text = (++shotCounter).ToString();
            timer.Enabled = true;
        }

        float vX, vY, gravity = 0.981f;
        int seconds = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            ++seconds;
            vX = (float)velocity / 10;
            vY = gravity * seconds;
            ball.Move(vX, vY);
            if (Hit(ball, target))
            {
                timer.Enabled = false;
                ball.X = 0;
                ball.Y = 0;
                seconds = 0;
                hitCount.Text = (++hitCounter).ToString();
                target = new Target(panel.Width, panel.Height);
            }
            if (ball.X + ball.Radius >= panel.Width || ball.Y + ball.Radius >= panel.Height)
            {
                timer.Enabled = false;
                ball.X = 0;
                ball.Y = 0;
                seconds = 0;
            }
            this.Refresh();
        }

        bool Hit(Ball ball, Target target)
        {
            float closeX = ball.X;
            float closeY = ball.Y;

            if (ball.X < target.X) closeX = target.X;
            if (ball.X > target.X + target.Width) closeX = target.X + target.Width;

            if (ball.Y < target.Y) closeY = target.Y;
            if (ball.Y > target.Y + target.Height) closeY = target.Y + target.Height;

            float distance = (float)Math.Sqrt(Math.Pow(closeX - ball.X, 2) + Math.Pow(closeY - ball.Y, 2));

            if (distance < ball.Radius)
                return true;

            return false;
        }
    }
}
