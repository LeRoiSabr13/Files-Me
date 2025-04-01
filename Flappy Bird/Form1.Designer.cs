namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Bird = new PictureBox();
            pipedown = new PictureBox();
            pipeup = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // Bird
            // 
            Bird.Image = Properties.Resources.Bird;
            Bird.Location = new Point(161, 290);
            Bird.Name = "Bird";
            Bird.Size = new Size(90, 80);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 0;
            Bird.TabStop = false;
            Bird.Click += Bird_Click;
            // 
            // pipedown
            // 
            pipedown.Image = Properties.Resources.pipedown;
            pipedown.Location = new Point(802, 428);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(123, 238);
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown.TabIndex = 1;
            pipedown.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.Image = Properties.Resources.pipeUp;
            pipeup.Location = new Point(802, -2);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(123, 209);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 2;
            pipeup.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-5, 653);
            ground.Name = "ground";
            ground.Size = new Size(960, 138);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Black;
            scoreText.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreText.ForeColor = Color.White;
            scoreText.Location = new Point(12, 699);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(133, 40);
            scoreText.TabIndex = 4;
            scoreText.Text = "SCORE:";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(977, 776);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeup);
            Controls.Add(pipedown);
            Controls.Add(Bird);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bird;
        private PictureBox pipedown;
        private PictureBox pipeup;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
