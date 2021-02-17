using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060MineSweepGameSolution
{
    public class TransparentPanel:Panel
    {
        const int WS_EX_TRANSPARENT = 0x20;
        public Bitmap Image { set; get; } = null;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle= cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
                e.Graphics.DrawImage(Image, e.ClipRectangle);
            base.OnPaint(e);
        }
    }
}
