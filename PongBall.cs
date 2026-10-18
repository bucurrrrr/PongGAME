using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGAME
{
    public class PongBall
    {
        private Control ball;

        public int ballXCoordinate = 5;
        public int ballYCoordinate = 5;
        private double ballSpeed = 1.0;
        public const double maxBallSpeed = 2.0;
        public PongBall(Control ballControl)
        {
            ball = ballControl;
        }

        public int Left
        {
            get => ball.Left;
            set => ball.Left = value;
        }

        public int Top
        {
            get => ball.Top;
            set => ball.Top = value;
        }

        public int Width => ball.Width;
        public int Height => ball.Height;

        public bool Intersects(Control other)
        {
            return ball.Bounds.IntersectsWith(other.Bounds);
        }

        public void SetBallSpeed(double nivel)
        { 
            if (nivel <= 0) return;
            ballSpeed = nivel;

            if (ballSpeed > maxBallSpeed) ballSpeed = maxBallSpeed;
        }

        public void IncreaseBallSpeed(double procent)
        {
            if (procent == 0) return;
            ballSpeed *= (1.0 + procent / 100.0);
            if (ballSpeed <= 0) ballSpeed = 1.0;

            if (ballSpeed > maxBallSpeed) ballSpeed = maxBallSpeed;
        }

        public void MoveStep()
        {
            int stepY = (int)(ballYCoordinate * ballSpeed);
            if (stepY == 0 && ballYCoordinate != 0)
            {
                stepY = (ballYCoordinate > 0) ? 1 : -1;
            }
            int stepX = (int)(ballXCoordinate * ballSpeed);
            if (stepX == 0 && ballXCoordinate != 0)
            {
                stepX = (ballXCoordinate > 0) ? 1 : -1;
            }

            Top = Top - stepY;
            Left = Left - stepX;
        }
    }
}
