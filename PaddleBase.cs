using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGAME
{
    public abstract class PaddleBase
    {
        protected PaddleBase(Control paddleControl)
        {
            PaddleControl = paddleControl;
        }
        public Control PaddleControl { get; }

        public int Top
        {
            get => PaddleControl.Top;
            set => PaddleControl.Top = value;
        }

        public int Height => PaddleControl.Height;

        public virtual void Update(int bottomBoundary) { }
    }
}
