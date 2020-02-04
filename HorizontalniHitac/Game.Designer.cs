namespace HorizontalniHitac
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.powerLabel = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.fireButton = new System.Windows.Forms.Button();
            this.shotLabel = new System.Windows.Forms.Label();
            this.shotCount = new System.Windows.Forms.Label();
            this.hitLabel = new System.Windows.Forms.Label();
            this.hitCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(0, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 422);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerLabel.Location = new System.Drawing.Point(12, 9);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(56, 19);
            this.powerLabel.TabIndex = 1;
            this.powerLabel.Text = "Power:";
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(74, 9);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(110, 22);
            this.powerTextBox.TabIndex = 2;
            // 
            // fireButton
            // 
            this.fireButton.Enabled = false;
            this.fireButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fireButton.Location = new System.Drawing.Point(204, 9);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(75, 23);
            this.fireButton.TabIndex = 3;
            this.fireButton.Text = "FIRE!";
            this.fireButton.UseVisualStyleBackColor = true;
            // 
            // shotLabel
            // 
            this.shotLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shotLabel.Location = new System.Drawing.Point(480, 9);
            this.shotLabel.Name = "shotLabel";
            this.shotLabel.Size = new System.Drawing.Size(56, 19);
            this.shotLabel.TabIndex = 4;
            this.shotLabel.Text = "Shots:";
            // 
            // shotCount
            // 
            this.shotCount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shotCount.Location = new System.Drawing.Point(542, 9);
            this.shotCount.Name = "shotCount";
            this.shotCount.Size = new System.Drawing.Size(39, 19);
            this.shotCount.TabIndex = 5;
            this.shotCount.Text = "0";
            // 
            // hitLabel
            // 
            this.hitLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hitLabel.Location = new System.Drawing.Point(604, 9);
            this.hitLabel.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.hitLabel.Name = "hitLabel";
            this.hitLabel.Size = new System.Drawing.Size(56, 19);
            this.hitLabel.TabIndex = 6;
            this.hitLabel.Text = "Hits:";
            // 
            // hitCount
            // 
            this.hitCount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hitCount.Location = new System.Drawing.Point(666, 9);
            this.hitCount.Name = "hitCount";
            this.hitCount.Size = new System.Drawing.Size(35, 19);
            this.hitCount.TabIndex = 7;
            this.hitCount.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.hitCount);
            this.Controls.Add(this.hitLabel);
            this.Controls.Add(this.shotCount);
            this.Controls.Add(this.shotLabel);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Horizontalni hitac";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Label shotLabel;
        private System.Windows.Forms.Label shotCount;
        private System.Windows.Forms.Label hitLabel;
        private System.Windows.Forms.Label hitCount;
    }
}

