using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGAME
{
    public partial class Form1 : Form
    {
        private PongEngine engine;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                engine = new PongEngine(
                    formControl: this,
                    ballControl: ball,
                    leftPaddleControl: leftPaddle,
                    rightPaddleControl: rightPaddle,
                    player1Label: player1ScoreLabel,
                    player2Label: player2ScoreLabel,
                    timer: pongTimer
                );
            }

            pongTimer.Stop();
        }
        public void StartGame()
        {
            if (engine == null) return;

            engine.RecomputeBoundaries();
            pongTimer.Start();
        }
        private void pongTimer_Tick(object sender, EventArgs e)
        {
            engine.Tick();
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            engine?.KeyDown(e.KeyCode);

            if (e.KeyCode == Keys.Tab)
            {
                using (var character = new CharacterForm())
                {
                    character.Owner = this;
                    pongTimer.Stop();
                    character.ShowDialog(this);
                }
                pongTimer.Start();
            }

            if (e.KeyCode == Keys.E && engine != null && engine.player1FreezeReady && !engine.rightPaddleFrozen)
            {
                engine.FreezePaddle(2);
                engine.player1FreezeReady = false;
                HideFreezeButtonForPlayer(1);
            }

            if ((e.KeyCode == Keys.RShiftKey || e.KeyCode == Keys.ShiftKey) && engine != null && engine.player2FreezeReady && !engine.leftPaddleFrozen)
            {
                engine.FreezePaddle(1);
                engine.player2FreezeReady = false;
                HideFreezeButtonForPlayer(2);
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            engine?.KeyUp(e.KeyCode);
        }
        public void ShowFreezeButtonForPlayer(int player)
        {
            if (player == 1)
                freezeButtonLeft.Visible = true;
            else
                freezeButtonRight.Visible = true;
        }
        public void HideFreezeButtonForPlayer(int player)
        {
            if (player == 1)
                freezeButtonLeft.Visible = false;
            else
                freezeButtonRight.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            engine?.RecomputeBoundaries();
            pongTimer.Stop();
            using (var character = new CharacterForm())
            {
                character.Owner = this;
                character.ShowDialog(this);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void freezeRight_Click(object sender, EventArgs e) { }
    }
}
