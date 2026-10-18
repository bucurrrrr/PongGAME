using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGAME
{
    public class PongEngine
    {
        private int player1Score = 0;
        private int player2Score = 0;

        private int bottomBoundary;
        private int xMidpoint;
        private int yMidpoint;

        private int spaceBarClicked = 0;
        private Random newBallLocation = new Random();
        //private int lastTrackedScore = 0;

        private Control form; 
        private Label player1ScoreLabel;
        private Label player2ScoreLabel;
        private Timer pongTimer;

        public int player1Combo = 0;
        public int player2Combo = 0;
        public bool player1FreezeReady = false;
        public bool player2FreezeReady = false;
        public bool rightPaddleFrozen = false;
        public bool leftPaddleFrozen = false;

        public PongBall ball { get; }
        public PlayerPaddle leftPaddle { get; }
        public PlayerPaddle rightPaddle { get; }

        public PongEngine(Control formControl, Control ballControl, Control leftPaddleControl, Control rightPaddleControl, Label player1Label, Label player2Label, Timer timer)
        {
            form = formControl;
            player1ScoreLabel = player1Label;
            player2ScoreLabel = player2Label;
            pongTimer = timer;

            ball = new PongBall(ballControl);
            leftPaddle = new PlayerPaddle(leftPaddleControl);
            rightPaddle = new PlayerPaddle(rightPaddleControl);

            ball.SetBallSpeed(0.8);     
            pongTimer.Interval = 16;   

            RecomputeBoundaries();
        }

        public void RecomputeBoundaries()
        {
            bottomBoundary = form.ClientSize.Height - leftPaddle.Height;
            xMidpoint = form.ClientSize.Width / 2;
            yMidpoint = form.ClientSize.Height / 2;
        }

        public void Tick()
        {
            int minY = 100;
            int maxY = form.ClientSize.Height - 100;
            if (maxY <= minY) maxY = minY + 1;

            int newLocation = newBallLocation.Next(minY, maxY);

            ball.MoveStep();

            if (ball.Left < 0)
            {
                ball.Left = xMidpoint;
                ball.Top = newLocation;
                ball.ballXCoordinate = -ball.ballXCoordinate;

                player2Score++;
                player2ScoreLabel.Text = player2Score.ToString();

                player2Combo++;
                player1Combo = 0;

                if (player2Combo == 2)
                {
                    player2FreezeReady = true;
                    (form as Form1).ShowFreezeButtonForPlayer(2);
                }
                else
                {
                    player2FreezeReady = false;
                    (form as Form1).HideFreezeButtonForPlayer(2);
                }
            }

            if (ball.Left + ball.Width > form.ClientSize.Width)
            {
                ball.Left = xMidpoint;
                ball.Top = newLocation;
                ball.ballXCoordinate = -ball.ballXCoordinate;

                player1Score++;
                player1ScoreLabel.Text = player1Score.ToString();

                player1Combo++;
                player2Combo = 0;

                if (player1Combo == 2)
                {
                    player1FreezeReady = true;
                    (form as Form1).ShowFreezeButtonForPlayer(1);
                }
                else
                {
                    player1FreezeReady = false;
                    (form as Form1).HideFreezeButtonForPlayer(1);
                }
            }

            if (ball.Top < 0 || ball.Top + ball.Height > form.ClientSize.Height)
            {
                ball.ballYCoordinate = -ball.ballYCoordinate;
            }

            if (ball.Intersects(leftPaddle.PaddleControl) || ball.Intersects(rightPaddle.PaddleControl))
            {
                ball.ballXCoordinate = -ball.ballXCoordinate;
                ball.IncreaseBallSpeed(5);
            }

            leftPaddle.Update(bottomBoundary);

            rightPaddle.Update(bottomBoundary);

            var f = (form as Form1);
            if (f != null && f.iceOverlayLeft != null && f.iceOverlayRight != null)
            {
                f.iceOverlayLeft.Top = leftPaddle.PaddleControl.Top;
                f.iceOverlayLeft.Left = leftPaddle.PaddleControl.Left;
                f.iceOverlayRight.Top = rightPaddle.PaddleControl.Top;
                f.iceOverlayRight.Left = rightPaddle.PaddleControl.Left;
            }

            if (player1Score == 5)
            {
                pongTimer.Stop();
                MessageBox.Show("PLAYER 1 WINS!", "GAME OVER");
            }
            else if (player2Score == 5)
            {
                pongTimer.Stop();
                MessageBox.Show("PLAYER 2 WINS!", "GAME OVER");
            }
 
           /* int scorMaximActual;
            if (player1Score > player2Score)
            {
                scorMaximActual = player1Score;
            }
            else
            {
                scorMaximActual = player2Score;
            }

            if (scorMaximActual > lastTrackedScore)
            {
                ball.IncreaseBallSpeed(10);
                lastTrackedScore = scorMaximActual;
            }*/
        }
        public void FreezePaddle(int player)
        {
            if (player == 2)
            {
                rightPaddleFrozen = true;
                rightPaddle.IsFrozen = true;
                (form as Form1).iceOverlayRight.Visible = true;
            }
            else
            {
                leftPaddleFrozen = true;
                leftPaddle.IsFrozen = true;
                (form as Form1).iceOverlayLeft.Visible = true;
            }

            var freezeTimer = new Timer();
            freezeTimer.Interval = 5000;
            freezeTimer.Tick += (s, e) =>
            {
                if (player == 2)
                {
                    rightPaddleFrozen = false;
                    rightPaddle.IsFrozen = false;
                    (form as Form1).iceOverlayRight.Visible = false;
                }
                else
                {
                    leftPaddleFrozen = false;
                    leftPaddle.IsFrozen = false;
                    (form as Form1).iceOverlayLeft.Visible = false;
                }
                freezeTimer.Stop();
                freezeTimer.Dispose();
            };
            freezeTimer.Start();
        }
        public void KeyDown(Keys key)
        {
            if (key == Keys.W)
            {
                leftPaddle.playerDetectedUp = true;
            }

            if (key == Keys.S)
            {
                leftPaddle.playerDetectedDown = true;
            }

            if (key == Keys.Up)
            {
                rightPaddle.playerDetectedUp = true;
            }

            if (key == Keys.Down)
            {
                rightPaddle.playerDetectedDown = true;
            }
        }

        public void KeyUp(Keys key)
        {
            if (key == Keys.W)
            {
                leftPaddle.playerDetectedUp = false;
            }

            if (key == Keys.S)
            {
                leftPaddle.playerDetectedDown = false;
            }

            if (key == Keys.Up)
            {
                rightPaddle.playerDetectedUp = false;
            }

            if (key == Keys.Down)
            {
                rightPaddle.playerDetectedDown = false;
            }

           
            if (key == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }
                spaceBarClicked++;
            }
        }
    }
}
