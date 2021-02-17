using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060MineSweepGameSolution
{
    class MineSweepPictureBox : PictureBox
    {
        private int r;
        private int c;

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
    }
}
