namespace PongGAME
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WhiteBird = new System.Windows.Forms.PictureBox();
            this.BlueBird = new System.Windows.Forms.PictureBox();
            this.RedBird = new System.Windows.Forms.PictureBox();
            this.YellowBird = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBird)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("ROG Fonts", 25.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(-2, 178);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1416, 117);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "CHOOSE YOUR CHARACTER";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhiteBird
            // 
            this.WhiteBird.Image = ((System.Drawing.Image)(resources.GetObject("WhiteBird.Image")));
            this.WhiteBird.Location = new System.Drawing.Point(154, 418);
            this.WhiteBird.Name = "WhiteBird";
            this.WhiteBird.Size = new System.Drawing.Size(189, 150);
            this.WhiteBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WhiteBird.TabIndex = 1;
            this.WhiteBird.TabStop = false;
            this.WhiteBird.Click += new System.EventHandler(this.WhiteBird_Click);
            // 
            // BlueBird
            // 
            this.BlueBird.Image = ((System.Drawing.Image)(resources.GetObject("BlueBird.Image")));
            this.BlueBird.Location = new System.Drawing.Point(459, 418);
            this.BlueBird.Name = "BlueBird";
            this.BlueBird.Size = new System.Drawing.Size(176, 153);
            this.BlueBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlueBird.TabIndex = 2;
            this.BlueBird.TabStop = false;
            this.BlueBird.Click += new System.EventHandler(this.BlueBird_Click);
            // 
            // RedBird
            // 
            this.RedBird.Image = ((System.Drawing.Image)(resources.GetObject("RedBird.Image")));
            this.RedBird.Location = new System.Drawing.Point(766, 418);
            this.RedBird.Name = "RedBird";
            this.RedBird.Size = new System.Drawing.Size(187, 148);
            this.RedBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedBird.TabIndex = 3;
            this.RedBird.TabStop = false;
            this.RedBird.Click += new System.EventHandler(this.RedBird_Click);
            // 
            // YellowBird
            // 
            this.YellowBird.Image = ((System.Drawing.Image)(resources.GetObject("YellowBird.Image")));
            this.YellowBird.Location = new System.Drawing.Point(1050, 387);
            this.YellowBird.Name = "YellowBird";
            this.YellowBird.Size = new System.Drawing.Size(188, 184);
            this.YellowBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YellowBird.TabIndex = 4;
            this.YellowBird.TabStop = false;
            this.YellowBird.Click += new System.EventHandler(this.YellowBird_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.IndianRed;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(512, 653);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(393, 133);
            this.startButton.TabIndex = 5;
            this.startButton.Text = " START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 839);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.YellowBird);
            this.Controls.Add(this.RedBird);
            this.Controls.Add(this.BlueBird);
            this.Controls.Add(this.WhiteBird);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1442, 910);
            this.MinimumSize = new System.Drawing.Size(1442, 910);
            this.Name = "CharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox BlueBird;
        private System.Windows.Forms.PictureBox RedBird;
        private System.Windows.Forms.PictureBox YellowBird;
        private System.Windows.Forms.PictureBox WhiteBird;
        private System.Windows.Forms.Button startButton;
    }
}