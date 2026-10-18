using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGAME
{
    public class PlayerPaddle : PaddleBase
    {
        public bool playerDetectedUp;
        public bool playerDetectedDown;
        public bool IsFrozen = false;
        public PlayerPaddle(Control paddleControl) : base(paddleControl) { }

        public override void Update(int bottomBoundary)
        {
            if (IsFrozen) return;

            if (playerDetectedUp == true && Top > 0)
            {
                Top = Top - 10;
            }

            if (playerDetectedDown == true && Top < bottomBoundary)
            {
                Top = Top + 10;
            }
        }
    }
}
