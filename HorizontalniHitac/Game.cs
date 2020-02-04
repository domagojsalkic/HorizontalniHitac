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
    }
}
