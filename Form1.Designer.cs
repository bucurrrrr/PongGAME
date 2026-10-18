namespace PongGAME
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iceOverlayLeft = new System.Windows.Forms.PictureBox();
            this.iceOverlayRight = new System.Windows.Forms.PictureBox();
            this.freezeButtonRight = new System.Windows.Forms.PictureBox();
            this.freezeButtonLeft = new System.Windows.Forms.PictureBox();
            this.leftPaddle = new System.Windows.Forms.PictureBox();
            this.rightPaddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iceOverlayLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceOverlayRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeButtonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeButtonLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.player1ScoreLabel.Font = new System.Drawing.Font("ROG Fonts", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.Location = new System.Drawing.Point(498, 32);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(100, 100);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "0";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.player2ScoreLabel.Font = new System.Drawing.Font("ROG Fonts", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.Location = new System.Drawing.Point(803, 32);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(100, 100);
            this.player2ScoreLabel.TabIndex = 4;
            this.player2ScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.iceOverlayLeft);
            this.panel1.Controls.Add(this.iceOverlayRight);
            this.panel1.Controls.Add(this.freezeButtonRight);
            this.panel1.Controls.Add(this.freezeButtonLeft);
            this.panel1.Controls.Add(this.leftPaddle);
            this.panel1.Controls.Add(this.rightPaddle);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.player1ScoreLabel);
            this.panel1.Controls.Add(this.player2ScoreLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 839);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iceOverlayLeft
            // 
            this.iceOverlayLeft.BackColor = System.Drawing.Color.Transparent;
            this.iceOverlayLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceOverlayLeft.BackgroundImage")));
            this.iceOverlayLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceOverlayLeft.Enabled = false;
            this.iceOverlayLeft.Location = new System.Drawing.Point(51, 313);
            this.iceOverlayLeft.Name = "iceOverlayLeft";
            this.iceOverlayLeft.Size = new System.Drawing.Size(52, 191);
            this.iceOverlayLeft.TabIndex = 8;
            this.iceOverlayLeft.TabStop = false;
            this.iceOverlayLeft.Visible = false;
            // 
            // iceOverlayRight
            // 
            this.iceOverlayRight.BackColor = System.Drawing.Color.Transparent;
            this.iceOverlayRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceOverlayRight.BackgroundImage")));
            this.iceOverlayRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceOverlayRight.Enabled = false;
            this.iceOverlayRight.Location = new System.Drawing.Point(1313, 313);
            this.iceOverlayRight.Name = "iceOverlayRight";
            this.iceOverlayRight.Size = new System.Drawing.Size(52, 191);
            this.iceOverlayRight.TabIndex = 7;
            this.iceOverlayRight.TabStop = false;
            this.iceOverlayRight.Visible = false;
            this.iceOverlayRight.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // freezeButtonRight
            // 
            this.freezeButtonRight.BackColor = System.Drawing.Color.Transparent;
            this.freezeButtonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("freezeButtonRight.BackgroundImage")));
            this.freezeButtonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.freezeButtonRight.Location = new System.Drawing.Point(909, 50);
            this.freezeButtonRight.Name = "freezeButtonRight";
            this.freezeButtonRight.Size = new System.Drawing.Size(64, 61);
            this.freezeButtonRight.TabIndex = 6;
            this.freezeButtonRight.TabStop = false;
            this.freezeButtonRight.Visible = false;
            this.freezeButtonRight.Click += new System.EventHandler(this.freezeRight_Click);
            // 
            // freezeButtonLeft
            // 
            this.freezeButtonLeft.BackColor = System.Drawing.Color.Transparent;
            this.freezeButtonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("freezeButtonLeft.BackgroundImage")));
            this.freezeButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.freezeButtonLeft.Location = new System.Drawing.Point(428, 50);
            this.freezeButtonLeft.Name = "freezeButtonLeft";
            this.freezeButtonLeft.Size = new System.Drawing.Size(64, 61);
            this.freezeButtonLeft.TabIndex = 5;
            this.freezeButtonLeft.TabStop = false;
            this.freezeButtonLeft.Visible = false;
            // 
            // leftPaddle
            // 
            this.leftPaddle.BackColor = System.Drawing.Color.DarkBlue;
            this.leftPaddle.Location = new System.Drawing.Point(12, 330);
            this.leftPaddle.Name = "leftPaddle";
            this.leftPaddle.Size = new System.Drawing.Size(33, 159);
            this.leftPaddle.TabIndex = 0;
            this.leftPaddle.TabStop = false;
            // 
            // rightPaddle
            // 
            this.rightPaddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPaddle.BackColor = System.Drawing.Color.Orange;
            this.rightPaddle.Location = new System.Drawing.Point(1371, 330);
            this.rightPaddle.Name = "rightPaddle";
            this.rightPaddle.Size = new System.Drawing.Size(33, 159);
            this.rightPaddle.TabIndex = 1;
            this.rightPaddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = global::PongGAME.Properties.Resources.CaracterGalbenPongpng;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.ErrorImage = null;
            this.ball.Location = new System.Drawing.Point(693, 457);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(66, 66);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1416, 839);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(2142, 1345);
            this.MinimumSize = new System.Drawing.Size(1442, 910);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iceOverlayLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceOverlayRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeButtonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeButtonLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox leftPaddle;
        private System.Windows.Forms.PictureBox rightPaddle;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        public System.Windows.Forms.PictureBox ball;
        public System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox freezeButtonRight;
        private System.Windows.Forms.PictureBox freezeButtonLeft;
        public System.Windows.Forms.PictureBox iceOverlayRight;
        public System.Windows.Forms.PictureBox iceOverlayLeft;
    }
}

