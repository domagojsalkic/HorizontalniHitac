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
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        Ball ball;
        Target target;
        double velocity;

        private void Game_Load(object sender, EventArgs e)
        {
            ball = new Ball();
            target = new Target(panel.ClientRectangle.Width, panel.ClientRectangle.Height);
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ball.Draw(e.Graphics);
            target.Draw(e.Graphics);
        }

        private void powerTextBox_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(powerTextBox.Text,out velocity))
            {
                fireButton.Enabled = true;
            }
            else
            {
                fireButton.Enabled = false;
                powerTextBox.Clear();
            }
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        float vX, vY, gravity = 0.981f;
        int seconds = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            ++seconds;
            vX = (float)velocity/10;
            vY = gravity * seconds;
            ball.Move(vX, vY);
            this.Refresh();
        }
    }
}
